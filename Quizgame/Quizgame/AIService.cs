using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Novacode;
using System.Drawing;

namespace Quizgame
{
    public class AIService
    {
        private readonly HttpClient _httpClient;
        private const string API_URL = "https://api.anthropic.com/v1/messages";
        private const string API_KEY = "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";  // Your API key here

        public AIService()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("anthropic-version", "2023-06-01");
            _httpClient.DefaultRequestHeaders.Add("x-api-key", API_KEY.Trim());
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", API_KEY.Trim());
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.Timeout = TimeSpan.FromMinutes(2);
        }

        public async Task<List<Question>> GenerateQuestions(string content, int numberOfQuestions)
        {
            try
            {
                var prompt = CreatePrompt(content, numberOfQuestions);
                var response = await SendRequest(prompt);
                return ParseResponse(response);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    $"Error generating questions: {ex.Message}",
                    "Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error
                );
                return new List<Question>();
            }
        }

        private string CreatePrompt(string content, int numberOfQuestions)
        {
            return $@"Generate {numberOfQuestions} multiple-choice questions about this content. Return questions in EXACTLY this format:

questions = [
    {{
        'question': 'What is SQL?',
        'options': {{
            'a': 'A programming language',
            'b': 'A database query language',
            'c': 'A web development framework',
            'd': 'An operating system'
        }},
        'correct': 'b',
        'explanation': 'SQL is a database query language used for managing and querying relational databases.'
    }}
]

Content: {content}

Important requirements:
1. Return ONLY the questions list in the exact format shown above
2. Generate exactly {numberOfQuestions} questions
3. Each question must have exactly 4 options labeled a, b, c, d
4. Ensure explanations are detailed and educational
5. Make questions test understanding rather than just memorization
6. Format must match exactly - use single quotes, not double quotes
7. DO NOT include any additional text or explanation outside the questions format";
        }

        private async Task<string> SendRequest(string prompt)
        {
            try
            {
                var requestBody = new
                {
                    model = "claude-3-opus-20240229",
                    max_tokens = 4096,
                    messages = new[]
                    {
                        new { role = "user", content = prompt }
                    }
                };

                var jsonContent = JsonSerializer.Serialize(requestBody);
                System.Diagnostics.Debug.WriteLine($"Request Body: {jsonContent}");

                var content = new StringContent(
                    jsonContent,
                    Encoding.UTF8,
                    "application/json"
                );

                // Print headers for debugging
                foreach (var header in _httpClient.DefaultRequestHeaders)
                {
                    System.Diagnostics.Debug.WriteLine($"Header: {header.Key} = {string.Join(", ", header.Value)}");
                }

                var response = await _httpClient.PostAsync(API_URL, content);
                var responseString = await response.Content.ReadAsStringAsync();

                System.Diagnostics.Debug.WriteLine($"Response Status: {response.StatusCode}");
                System.Diagnostics.Debug.WriteLine($"Response Content: {responseString}");

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"API request failed: {responseString}");
                }

                var responseObject = JsonSerializer.Deserialize<JsonElement>(responseString);
                return responseObject
                    .GetProperty("content")
                    .EnumerateArray()
                    .First()
                    .GetProperty("text")
                    .GetString();
            }
            catch (Exception ex)
            {
                throw new Exception($"API request failed: {ex.Message}");
            }
        }

        public void SaveQuestionsAsDocx(List<Question> questions, string filePath)
        {
            try
            {
                using (var doc = DocX.Create(filePath))
                {
                    // Title
                    var title = doc.InsertParagraph("Quiz Questions")
                                   .FontSize(18)
                                   .Bold();
                    title.Alignment = Alignment.center;

                    for (int i = 0; i < questions.Count; i++)
                    {
                        var q = questions[i];
                        if (string.IsNullOrWhiteSpace(q.QuestionText) || q.Options == null || string.IsNullOrWhiteSpace(q.CorrectAnswer))
                            continue;

                        // Question
                        doc.InsertParagraph($"Question {i + 1}: {q.QuestionText}")
                            .FontSize(12)
                            .Bold();

                        // Options
                        foreach (var option in q.Options)
                        {
                            doc.InsertParagraph($"{option.Key}) {option.Value}")
                                .FontSize(11)
                                .IndentationBefore = 1.0f;
                        }

                        // Correct Answer
                        doc.InsertParagraph($"Correct Answer: {q.CorrectAnswer}")
                            .FontSize(11)
                            .Color(Color.Green)
                            .Italic();

                        // Explanation
                        doc.InsertParagraph($"Explanation: {q.Explanation}")
                            .FontSize(11)
                            .SpacingAfter(15);
                    }

                    doc.Save();
                }

                System.Windows.Forms.MessageBox.Show("Questions saved successfully as .docx!", "Success");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Failed to save questions as .docx: {ex.Message}", "Error");
            }
        }

        private List<Question> ParseResponse(string response)
        {
            try
            {
                // Remove any potential extra text before or after the questions list
                var startIndex = response.IndexOf("questions = [");
                var endIndex = response.LastIndexOf("]") + 1;
                if (startIndex < 0 || endIndex <= startIndex)
                {
                    throw new Exception("Invalid response format");
                }

                var questionsList = response.Substring(startIndex, endIndex - startIndex);

                // Use QuestionParserService to parse the questions
                var parserService = new QuestionParserService();
                return parserService.ParseQuestions(questionsList);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to parse AI response: {ex.Message}");
            }
        }
    }
}