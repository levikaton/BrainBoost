using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quizgame
{
    public partial class ContentInputForm : Form
    {
        private QuestionParserService _parserService;
        public List<Question> GeneratedQuestions { get; private set; }

        public ContentInputForm()
        {
            InitializeComponent();
            _parserService = new QuestionParserService();

            // Change the instruction text to match our new approach
            instructionLabel.Text = "Paste your questions list here:";

            // Hide the question count control since we'll use all pasted questions
            questionsLabel.Visible = false;
            questionCountUpDown.Visible = false;

            // Update button text
            submitButton.Text = "Start Quiz";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contentTextBox.Text))
            {
                MessageBox.Show("Please paste your questions first!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            submitButton.Enabled = false;
            submitButton.Text = "Processing...";

            try
            {
                // Parse the pasted questions
                GeneratedQuestions = _parserService.ParseQuestions(contentTextBox.Text);

                if (GeneratedQuestions != null && GeneratedQuestions.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    throw new Exception("No questions were found in the pasted text.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing questions: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                submitButton.Enabled = true;
                submitButton.Text = "Start Quiz";
            }
        }
    }
}