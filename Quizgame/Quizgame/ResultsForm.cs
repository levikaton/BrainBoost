using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quizgame
{
    public partial class ResultsForm : Form
    {
        // Quiz result data
        private int score;
        private int totalQuestions;
        private int totalTimeSpent;
        private double averageTimePerQuestion;
        private List<Question> wrongQuestions;
        private bool isReviewMode;
        private int reviewCount;

        // Result of user's choice
        public enum ResultAction
        {
            ReviewWrongQuestions,
            StartNewQuiz,
            None
        }

        public ResultAction UserChoice { get; private set; }

        public ResultsForm(int score, int totalQuestions, int totalTimeSpent,
                          List<Question> wrongQuestions, bool isReviewMode, int reviewCount)
        {
            InitializeComponent();

            // Store quiz data
            this.score = score;
            this.totalQuestions = totalQuestions;
            this.totalTimeSpent = totalTimeSpent;
            this.wrongQuestions = wrongQuestions;
            this.isReviewMode = isReviewMode;
            this.reviewCount = reviewCount;

            // Calculate average time
            if (totalQuestions > 0)
                this.averageTimePerQuestion = (double)totalTimeSpent / totalQuestions;
            else
                this.averageTimePerQuestion = 0;

            // Set default result
            this.UserChoice = ResultAction.None;

            // Initialize UI
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Calculate percentage
            double percentage = (score / (double)totalQuestions) * 100;

            // Update score display
            lblScoreValue.Text = $"{score}/{totalQuestions}";
            lblPercentage.Text = $"{percentage:F1}%";

            // Update progress bar
            progressBarScore.Value = (int)percentage;

            // Update medal/trophy based on score
            if (percentage >= 90)
                lblTrophy.Text = "🏆";  // Gold trophy
            else if (percentage >= 70)
                lblTrophy.Text = "🥈";  // Silver medal
            else
                lblTrophy.Text = "🥉";  // Bronze medal

            // Time statistics
            int totalMinutes = totalTimeSpent / 60;
            int totalSeconds = totalTimeSpent % 60;

            int avgMinutes = (int)(averageTimePerQuestion / 60);
            int avgSeconds = (int)(averageTimePerQuestion % 60);

            lblTimeValue.Text = $"{totalMinutes:00}:{totalSeconds:00}";
            lblAvgTimeValue.Text = $"{avgMinutes:00}:{avgSeconds:00}";

            // Performance summary
            if (percentage >= 90)
                lblPerformanceSummary.Text = "Outstanding! Nearly perfect score!";
            else if (percentage >= 70)
                lblPerformanceSummary.Text = "Good job! Well above average!";
            else if (percentage >= 50)
                lblPerformanceSummary.Text = "Nice effort! Keep practicing!";
            else
                lblPerformanceSummary.Text = "Keep studying, you'll improve!";

            // Set improvement tips
            lstImprovementTips.Items.Clear();

            if (percentage < 70)
                lstImprovementTips.Items.Add("Try reviewing the material more carefully");

            if (averageTimePerQuestion > 20)
                lstImprovementTips.Items.Add("Work on your speed for better efficiency");

            if (wrongQuestions.Count > 0)
                lstImprovementTips.Items.Add("Focus on reviewing the questions you missed");

            // Update wrong questions info
            if (wrongQuestions.Count > 0)
            {
                lblWrongQuestions.Text = $"You answered {wrongQuestions.Count} questions incorrectly";
                btnReviewWrong.Enabled = true;
            }
            else
            {
                lblWrongQuestions.Text = "Perfect! You didn't miss any questions!";
                btnReviewWrong.Enabled = false;
            }

            // Update review round info if applicable
            if (isReviewMode)
            {
                lblReviewRound.Visible = true;
                lblReviewRound.Text = $"Review Round: {reviewCount}/2";

                if (reviewCount >= 2)
                    btnReviewWrong.Enabled = false;
            }
            else
            {
                lblReviewRound.Visible = false;
            }

            // Update chart on panel
            chartPanel.Invalidate();  // This will trigger the Paint event
        }

        private void chartPanel_Paint(object sender, PaintEventArgs e)
        {
            if (totalQuestions == 0) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Calculate angles for pie chart
            int correctAngle = (int)(360.0 * score / totalQuestions);
            int wrongAngle = 360 - correctAngle;

            // Draw the pie chart
            if (score > 0)
            {
                g.FillPie(Brushes.LightGreen, 10, 10, 100, 100, 0, correctAngle);
            }

            if (score < totalQuestions)
            {
                g.FillPie(Brushes.LightPink, 10, 10, 100, 100, correctAngle, wrongAngle);
            }

            // Draw border
            g.DrawEllipse(Pens.Gray, 10, 10, 100, 100);

            // Add legend text
            g.DrawString($"Correct: {score}", new Font("Arial", 8), Brushes.DarkGreen, 10, 115);

            if (score < totalQuestions)
            {
                string wrongText = $"Wrong: {totalQuestions - score}";
                g.DrawString(wrongText, new Font("Arial", 8), Brushes.DarkRed, 10, 135);
            }
        }

        private void btnStartNewQuiz_Click(object sender, EventArgs e)
        {
            UserChoice = ResultAction.StartNewQuiz;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnReviewWrong_Click(object sender, EventArgs e)
        {
            if (wrongQuestions.Count > 0 && reviewCount < 2)
            {
                UserChoice = ResultAction.ReviewWrongQuestions;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCopyResults_Click(object sender, EventArgs e)
        {
            double percentage = (score / (double)totalQuestions) * 100;
            int totalMinutes = totalTimeSpent / 60;
            int totalSeconds = totalTimeSpent % 60;

            string resultText = $"Quiz Results\n" +
                               $"Score: {score}/{totalQuestions} ({percentage:F1}%)\n" +
                               $"Time: {totalMinutes:00}:{totalSeconds:00}\n" +
                               $"{lblPerformanceSummary.Text}";

            Clipboard.SetText(resultText);
            MessageBox.Show("Results copied to clipboard!", "Share Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}