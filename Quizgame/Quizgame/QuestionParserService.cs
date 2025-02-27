using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Quizgame
{
    public class QuestionParserService
    {
        public List<Question> ParseQuestions(string questionText)
        {
            try
            {
                var questions = new List<Question>();

                // Clean up the input text and remove the "questions = " part
                questionText = questionText.Trim();
                if (questionText.StartsWith("questions = "))
                {
                    questionText = questionText.Substring("questions = ".Length);
                }

                // Split into individual question blocks using regex
                var questionBlocks = Regex.Split(questionText, @"},\s*{")
                    .Select(block => block.Trim())
                    .Select(block => block.TrimStart('[', '{').TrimEnd(']', '}'))
                    .Where(block => !string.IsNullOrWhiteSpace(block));

                foreach (var block in questionBlocks)
                {
                    try
                    {
                        var question = ParseQuestionBlock(block);
                        if (question != null)
                        {
                            questions.Add(question);
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Error parsing question block: {ex.Message}");
                    }
                }

                if (questions.Count == 0)
                {
                    throw new Exception("No valid questions were found in the input text.");
                }

                return questions;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error parsing questions: {ex.Message}");
            }
        }

        private Question ParseQuestionBlock(string block)
        {
            var question = new Question();
            question.Options = new Dictionary<string, string>();

            // Helper function to unescape text
            string UnescapeText(string text)
            {
                return text
                    .Replace("\\'", "'")
                    .Replace("\\\"", "\"")
                    .Replace("\\n", "\n")
                    .Replace("\\\\", "\\");
            }

            // Extract question text - use negative lookahead to handle escaped quotes
            var questionMatch = Regex.Match(block, @"'question':\s*'((?:[^'\\]|\\.)*)'");
            if (questionMatch.Success)
            {
                question.QuestionText = UnescapeText(questionMatch.Groups[1].Value);
            }

            // Extract options
            var optionsSection = Regex.Match(block, @"'options':\s*{([^}]*)}");
            if (optionsSection.Success)
            {
                var optionsText = optionsSection.Groups[1].Value;
                var optionMatches = Regex.Matches(optionsText, @"'([a-d])':\s*'((?:[^'\\]|\\.)*)'");
                foreach (Match match in optionMatches)
                {
                    var key = match.Groups[1].Value;
                    var value = UnescapeText(match.Groups[2].Value);
                    question.Options[key] = value;
                }
            }

            // Extract correct answer
            var correctMatch = Regex.Match(block, @"'correct':\s*'([^']*)'");
            if (correctMatch.Success)
            {
                question.CorrectAnswer = UnescapeText(correctMatch.Groups[1].Value);
            }

            // Extract explanation
            var explanationMatch = Regex.Match(block, @"'explanation':\s*'((?:[^'\\]|\\.)*)'");
            if (explanationMatch.Success)
            {
                question.Explanation = UnescapeText(explanationMatch.Groups[1].Value);
            }

            // Validate the question
            if (string.IsNullOrWhiteSpace(question.QuestionText) ||
                question.Options.Count != 4 ||
                string.IsNullOrWhiteSpace(question.CorrectAnswer) ||
                string.IsNullOrWhiteSpace(question.Explanation))
            {
                return null;
            }

            return question;
        }
    }
}