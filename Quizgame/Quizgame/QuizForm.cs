using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizgame
{
    public partial class QuizForm : Form
    {
        // Core data structures for managing questions
        private readonly List<Question> originalQuestions;  // Immutable list of original questions
        private List<Question> currentQuestions;           // Current active question set
        private List<Question> wrongQuestions;             // Questions answered incorrectly

        // State tracking variables
        private bool isReviewMode;                        // Indicates if we're reviewing wrong questions
        private int reviewCount;                          // Tracks number of review rounds completed
        private int currentQuestionIndex;                 // Index of current question being displayed
        private int score;                                // Current score in this round
        private int totalQuestions;                       // Total questions in current round

        // UI and randomization
        private readonly Random random;
        private readonly Dictionary<string, Button> answerButtons; // Dictionary mapping answer keys to buttons

        // Timer related fields
        private Timer quizTimer;
        private int elapsedSeconds;
        private Dictionary<int, int> questionTimes; // Tracks time spent on each question
        private int totalTimeSpent; // Total time for the entire quiz

        public QuizForm(List<Question> generatedQuestions)
        {
            // Initialize UI components (created by Form Designer)
            InitializeComponent();

            // Initialize core components
            originalQuestions = new List<Question>(generatedQuestions); // Ensure originalQuestions is immutable
            wrongQuestions = new List<Question>();
            random = new Random();

            // Initialize timer components
            quizTimer = new Timer();
            quizTimer.Interval = 1000; // 1 second
            quizTimer.Tick += QuizTimer_Tick;
            elapsedSeconds = 0;
            totalTimeSpent = 0;
            questionTimes = new Dictionary<int, int>();

            // Initialize the answer buttons dictionary in the constructor
            answerButtons = new Dictionary<string, Button>
            {
                { "a", btnA },
                { "b", btnB },
                { "c", btnC },
                { "d", btnD }
            };

            // Set up button event handlers
            foreach (var button in answerButtons.Values)
            {
                button.Click += AnswerButton_Click;
            }

            // Start first quiz round
            StartNewQuiz();
        }

        /// <summary>
        /// Timer tick event handler - updates the timer display
        /// </summary>
        private void QuizTimer_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            totalTimeSpent++;
            UpdateTimerDisplay();
        }

        /// <summary>
        /// Updates the timer display with current elapsed time
        /// </summary>
        private void UpdateTimerDisplay()
        {
            int minutes = elapsedSeconds / 60;
            int seconds = elapsedSeconds % 60;
            timerLabel.Text = $"Time: {minutes:00}:{seconds:00}";
        }

        /// <summary>
        /// Starts a completely new quiz with original questions
        /// </summary>
        private void StartNewQuiz()
        {
            // Reset to original state
            currentQuestions = new List<Question>(originalQuestions); // Create a fresh copy of originalQuestions
            wrongQuestions = new List<Question>();
            reviewCount = 0;
            isReviewMode = false;

            // Reset timer tracking
            elapsedSeconds = 0;
            totalTimeSpent = 0;
            questionTimes.Clear();
            UpdateTimerDisplay();
            timerLabel.Visible = true;
            quizTimer.Start();

            // Debugging: Verify the count of original and current questions
            Console.WriteLine($"Original Questions Count: {originalQuestions.Count}");
            Console.WriteLine($"Current Questions Count after reset: {currentQuestions.Count}");

            // Make answer buttons visible again
            foreach (var button in answerButtons.Values)
            {
                button.Visible = true;
            }

            // Make next button visible again
            nextButton.Visible = true;

            // Initialize the quiz
            ResetQuizRound();
        }

        /// <summary>
        /// Resets the current quiz round (either regular or review)
        /// </summary>
        private void ResetQuizRound()
        {
            // Reset scoring and question tracking
            score = 0;
            currentQuestionIndex = 0;

            if (isReviewMode)
            {
                // Use wrong questions for review round
                currentQuestions = new List<Question>(wrongQuestions);
                wrongQuestions = new List<Question>(); // New list for current review
            }

            // Randomize question order
            currentQuestions = currentQuestions.OrderBy(x => random.Next()).ToList();
            totalQuestions = currentQuestions.Count;

            // Debugging: Verify the count of current questions after randomization
            Console.WriteLine($"Current Questions Count after randomization: {currentQuestions.Count}");

            // Update UI
            DisplayCurrentQuestion();
            UpdateScoreDisplay();
        }

        /// <summary>
        /// Handles when an answer button is clicked
        /// </summary>
        private void AnswerButton_Click(object sender, EventArgs e)
        {
            // Stop the timer when an answer is selected
            quizTimer.Stop();

            var selectedButton = (Button)sender;
            var selectedAnswer = (string)selectedButton.Tag;
            var currentQuestion = currentQuestions[currentQuestionIndex];

            // Record time for this question
            questionTimes[currentQuestionIndex] = elapsedSeconds;

            // Disable all answer buttons after selection
            foreach (var button in answerButtons.Values)
            {
                button.Enabled = false;
            }

            // Check if answer is correct
            bool isCorrect = selectedAnswer == currentQuestion.CorrectAnswer;

            if (isCorrect)
            {
                HandleCorrectAnswer();
            }
            else
            {
                HandleIncorrectAnswer(selectedAnswer, currentQuestion);
            }

            // Update UI
            HighlightAnswers(selectedAnswer, currentQuestion.CorrectAnswer);
            ShowExplanation(currentQuestion.Explanation);
            UpdateScoreDisplay();
            nextButton.Enabled = true;
        }

        /// <summary>
        /// Handles logic for correct answers
        /// </summary>
        private void HandleCorrectAnswer()
        {
            score++;
            feedbackLabel.Text = "✓ Correct!";
            feedbackLabel.ForeColor = Color.Green;
        }

        /// <summary>
        /// Handles logic for incorrect answers
        /// </summary>
        private void HandleIncorrectAnswer(string selectedAnswer, Question question)
        {
            feedbackLabel.Text = $"✗ Wrong! The correct answer was: {question.CorrectAnswer}) {question.Options[question.CorrectAnswer]}";
            feedbackLabel.ForeColor = Color.Red;

            // Track wrong questions based on mode
            if (!isReviewMode || (isReviewMode && reviewCount < 2))
            {
                wrongQuestions.Add(question);
            }
        }

        /// <summary>
        /// Highlights the selected and correct answers
        /// </summary>
        private void HighlightAnswers(string selectedAnswer, string correctAnswer)
        {
            // Highlight correct answer in green
            answerButtons[correctAnswer].BackColor = Color.LightGreen;

            // If wrong answer selected, highlight it in pink
            if (selectedAnswer != correctAnswer)
            {
                answerButtons[selectedAnswer].BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Displays the next question
        /// </summary>
        private void nextButton_Click(object sender, EventArgs e)
        {
            // Reset elapsed time for next question
            if (currentQuestionIndex + 1 < totalQuestions)
            {
                // Start timing for the next question
                elapsedSeconds = 0;
                UpdateTimerDisplay();
                quizTimer.Start();
            }

            currentQuestionIndex++;
            DisplayCurrentQuestion();
        }

        /// <summary>
        /// Starts review mode for wrong questions
        /// </summary>
        private void reviewButton_Click(object sender, EventArgs e)
        {
            if (reviewCount >= 2)
            {
                StartNewQuiz();
                return;
            }

            isReviewMode = true;
            reviewCount++;

            // Reset timer for review mode
            elapsedSeconds = 0;
            totalTimeSpent = 0;
            questionTimes.Clear();
            UpdateTimerDisplay();
            timerLabel.Visible = true;
            quizTimer.Start();

            // Show all UI elements
            foreach (var button in answerButtons.Values)
            {
                button.Visible = true;
            }
            nextButton.Visible = true;

            ResetQuizRound();
        }

        /// <summary>
        /// Restarts the entire quiz
        /// </summary>
        private void restartButton_Click(object sender, EventArgs e)
        {
            StartNewQuiz();
        }

        /// <summary>
        /// Updates the score display
        /// </summary>
        private void UpdateScoreDisplay()
        {
            scoreLabel.Text = $"Score: {score}/{currentQuestionIndex + 1}";

            // Reset button colors
            foreach (var button in answerButtons.Values)
            {
                button.BackColor = SystemColors.Control;
            }
        }

        /// <summary>
        /// Displays the current question
        /// </summary>
        private void DisplayCurrentQuestion()
        {
            if (currentQuestionIndex < totalQuestions)
            {
                DisplayQuestionContent();
            }
            else
            {
                ShowQuizResults();
            }
        }

        /// <summary>
        /// Displays the content of the current question
        /// </summary>
        private void DisplayQuestionContent()
        {
            var question = currentQuestions[currentQuestionIndex];

            // Update question text
            questionLabel.Text = $"Question {currentQuestionIndex + 1}:\n{question.QuestionText}";

            // Update answer buttons
            foreach (var option in question.Options)
            {
                var button = answerButtons[option.Key];
                button.Text = $"{option.Key}) {option.Value}";
                button.Enabled = true;
                button.BackColor = SystemColors.Control;
                button.Tag = option.Key;
            }

            // Reset UI elements
            nextButton.Enabled = false;
            feedbackLabel.Text = "";
            explanationTextBox.Text = "";
            reviewButton.Visible = false;
            restartButton.Visible = false;
        }

        /// <summary>
        /// Shows the explanation for the current question
        /// </summary>
        private void ShowExplanation(string explanation)
        {
            explanationTextBox.Text = explanation;
        }

        /// <summary>
        /// Shows the final results of the quiz
        /// </summary>
        private void ShowQuizResults()
        {
            // Stop the timer and hide timer label
            quizTimer.Stop();
            timerLabel.Visible = false;

            // Calculate average time
            int avgTime = 0;
            if (questionTimes.Count > 0)
            {
                avgTime = (int)questionTimes.Values.Average();
            }

            // Launch the results form
            using (var resultsForm = new ResultsForm(
                score,
                totalQuestions,
                totalTimeSpent,
                wrongQuestions,
                isReviewMode,
                reviewCount))
            {
                if (resultsForm.ShowDialog() == DialogResult.OK)
                {
                    // Handle the user's choice
                    switch (resultsForm.UserChoice)
                    {
                        case ResultsForm.ResultAction.ReviewWrongQuestions:
                            reviewButton_Click(this, EventArgs.Empty);
                            break;

                        case ResultsForm.ResultAction.StartNewQuiz:
                            StartNewQuiz();
                            break;
                    }
                }
                else
                {
                    // If dialog was canceled/closed without a choice, just show restart button
                    // Hide answer buttons
                    foreach (var button in answerButtons.Values)
                    {
                        button.Visible = false;
                    }

                    // Update UI elements
                    questionLabel.Text = "Quiz Completed!";
                    scoreLabel.Text = $"Score: {score}/{totalQuestions}";
                    nextButton.Visible = false;
                    explanationTextBox.Text = "";
                    feedbackLabel.Text = "Quiz completed. Start a new quiz!";
                    reviewButton.Visible = false;
                    restartButton.Visible = true;
                }
            }
        }
    }

    public class Question
    {
        public string QuestionText { get; set; }
        public Dictionary<string, string> Options { get; set; }
        public string CorrectAnswer { get; set; }
        public string Explanation { get; set; }
    }
}