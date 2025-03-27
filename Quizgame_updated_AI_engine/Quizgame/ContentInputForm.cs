using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quizgame
{
    public partial class ContentInputForm : Form
    {
        private AIService _aiService;
        public List<Question> GeneratedQuestions { get; private set; }

        public ContentInputForm()
        {
            InitializeComponent();
            _aiService = new AIService();

            // Update the instruction text
            instructionLabel.Text = "Paste your content here:";

            // Show the question count control since we'll use it
            questionsLabel.Visible = true;
            questionCountUpDown.Visible = true;

            // Update button text
            submitButton.Text = "Generate Questions";
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contentTextBox.Text))
            {
                MessageBox.Show("Please paste your content first!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            submitButton.Enabled = false;
            submitButton.Text = "Generating...";
            Cursor = Cursors.WaitCursor;

            try
            {
                // Get questions from AI service
                int questionCount = (int)questionCountUpDown.Value;
                GeneratedQuestions = await _aiService.GenerateQuestions(contentTextBox.Text, questionCount);

                if (GeneratedQuestions != null && GeneratedQuestions.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    throw new Exception("No questions were generated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating questions: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                submitButton.Enabled = true;
                submitButton.Text = "Generate Questions";
                Cursor = Cursors.Default;
            }
        }

        private void questionCountUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}