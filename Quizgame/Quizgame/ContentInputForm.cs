using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace Quizgame
{
    public partial class ContentInputForm : Form
    {
        private QuestionParserService _parserService;
        public List<Question> GeneratedQuestions { get; private set; }

        // Keep track of questions added via form
        private List<Question> _formQuestions = new List<Question>();
        private int _currentQuestionIndex = -1;

        public ContentInputForm()
        {
            InitializeComponent();
            _parserService = new QuestionParserService();

            // Setup input mode toggle
            inputModePanel.Visible = true;
            jsonInputPanel.Visible = true;
            formInputPanel.Visible = false;

            // Initialize form questions list view
            SetupListView();

            // Set initial radio button state
            jsonRadioButton.Checked = true;

            // Update button event handlers
            addQuestionButton.Click += addQuestionButton_Click;
            editQuestionButton.Click += editQuestionButton_Click;
            deleteQuestionButton.Click += deleteQuestionButton_Click;
            clearAllButton.Click += clearAllButton_Click;

            // Set the default correct answer
            optionARadioButton.Checked = true;
        }

        private void SetupListView()
        {
            // Configure list view columns
            questionsListView.View = View.Details;
            questionsListView.FullRowSelect = true;
            questionsListView.Columns.Add("Question", 300);
            questionsListView.Columns.Add("Correct Answer", 100);

            // Add selection change event
            questionsListView.SelectedIndexChanged += questionsListView_SelectedIndexChanged;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (jsonRadioButton.Checked)
            {
                ProcessJsonInput();
            }
            else
            {
                ProcessFormInput();
            }
        }

        private void ProcessJsonInput()
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

        private void ProcessFormInput()
        {
            if (_formQuestions.Count == 0)
            {
                MessageBox.Show("Please add at least one question first!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GeneratedQuestions = new List<Question>(_formQuestions);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void jsonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (jsonRadioButton.Checked)
            {
                jsonInputPanel.Visible = true;
                formInputPanel.Visible = false;

                // Update labels and buttons
                instructionLabel.Text = "Paste your questions list here:";
                submitButton.Text = "Start Quiz";
            }
        }

        private void formRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (formRadioButton.Checked)
            {
                jsonInputPanel.Visible = false;
                formInputPanel.Visible = true;

                // Update labels and buttons
                instructionLabel.Text = "Create your questions using the form:";
                submitButton.Text = "Start Quiz";
            }
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            if (ValidateFormInputs())
            {
                AddOrUpdateQuestion();
                ClearFormInputs();
                _currentQuestionIndex = -1;

                // Update UI elements
                addQuestionButton.Text = "Add Question";
                editQuestionButton.Enabled = false;
            }
        }

        private void editQuestionButton_Click(object sender, EventArgs e)
        {
            if (_currentQuestionIndex >= 0 && ValidateFormInputs())
            {
                AddOrUpdateQuestion();
                ClearFormInputs();
                _currentQuestionIndex = -1;

                // Update UI elements
                addQuestionButton.Text = "Add Question";
                editQuestionButton.Enabled = false;
            }
        }

        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            if (questionsListView.SelectedIndices.Count > 0)
            {
                int selectedIndex = questionsListView.SelectedIndices[0];
                _formQuestions.RemoveAt(selectedIndex);
                questionsListView.Items.RemoveAt(selectedIndex);
                ClearFormInputs();
                _currentQuestionIndex = -1;

                // Update UI elements
                addQuestionButton.Text = "Add Question";
                editQuestionButton.Enabled = false;
                deleteQuestionButton.Enabled = false;
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all questions?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _formQuestions.Clear();
                questionsListView.Items.Clear();
                ClearFormInputs();
                _currentQuestionIndex = -1;

                // Update UI elements
                addQuestionButton.Text = "Add Question";
                editQuestionButton.Enabled = false;
                deleteQuestionButton.Enabled = false;
            }
        }

        private void questionsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (questionsListView.SelectedIndices.Count > 0)
            {
                int selectedIndex = questionsListView.SelectedIndices[0];
                _currentQuestionIndex = selectedIndex;
                LoadQuestionToForm(_formQuestions[selectedIndex]);

                // Update UI elements
                addQuestionButton.Text = "Save as New";
                editQuestionButton.Enabled = true;
                deleteQuestionButton.Enabled = true;
            }
            else
            {
                _currentQuestionIndex = -1;
                editQuestionButton.Enabled = false;
                deleteQuestionButton.Enabled = false;
            }
        }

        private bool ValidateFormInputs()
        {
            // Validate question text
            if (string.IsNullOrWhiteSpace(questionTextBox.Text))
            {
                MessageBox.Show("Please enter a question.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate options
            if (string.IsNullOrWhiteSpace(optionATextBox.Text) ||
                string.IsNullOrWhiteSpace(optionBTextBox.Text) ||
                string.IsNullOrWhiteSpace(optionCTextBox.Text) ||
                string.IsNullOrWhiteSpace(optionDTextBox.Text))
            {
                MessageBox.Show("Please enter all four answer options.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate explanation
            if (string.IsNullOrWhiteSpace(explanationTextBox.Text))
            {
                MessageBox.Show("Please enter an explanation.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void AddOrUpdateQuestion()
        {
            // Get the correct answer
            string correctAnswer = GetSelectedCorrectAnswer();

            // Create question object
            var question = new Question
            {
                QuestionText = questionTextBox.Text,
                Options = new Dictionary<string, string>
                {
                    { "a", optionATextBox.Text },
                    { "b", optionBTextBox.Text },
                    { "c", optionCTextBox.Text },
                    { "d", optionDTextBox.Text }
                },
                CorrectAnswer = correctAnswer,
                Explanation = explanationTextBox.Text
            };

            // Add or update in the list
            if (_currentQuestionIndex >= 0 && _currentQuestionIndex < _formQuestions.Count)
            {
                _formQuestions[_currentQuestionIndex] = question;
                questionsListView.Items[_currentQuestionIndex].SubItems[0].Text = question.QuestionText;
                questionsListView.Items[_currentQuestionIndex].SubItems[1].Text =
                    $"{question.CorrectAnswer}) {question.Options[question.CorrectAnswer]}";
            }
            else
            {
                _formQuestions.Add(question);

                // Add to list view
                var item = new ListViewItem(question.QuestionText);
                item.SubItems.Add($"{question.CorrectAnswer}) {question.Options[question.CorrectAnswer]}");
                questionsListView.Items.Add(item);
            }
        }

        private string GetSelectedCorrectAnswer()
        {
            if (optionARadioButton.Checked) return "a";
            if (optionBRadioButton.Checked) return "b";
            if (optionCRadioButton.Checked) return "c";
            if (optionDRadioButton.Checked) return "d";
            return "a"; // Default to A if somehow none are checked
        }

        private void LoadQuestionToForm(Question question)
        {
            questionTextBox.Text = question.QuestionText;
            optionATextBox.Text = question.Options["a"];
            optionBTextBox.Text = question.Options["b"];
            optionCTextBox.Text = question.Options["c"];
            optionDTextBox.Text = question.Options["d"];
            explanationTextBox.Text = question.Explanation;

            // Set the correct radio button
            switch (question.CorrectAnswer)
            {
                case "a": optionARadioButton.Checked = true; break;
                case "b": optionBRadioButton.Checked = true; break;
                case "c": optionCRadioButton.Checked = true; break;
                case "d": optionDRadioButton.Checked = true; break;
            }
        }

        private void ClearFormInputs()
        {
            questionTextBox.Text = "";
            optionATextBox.Text = "";
            optionBTextBox.Text = "";
            optionCTextBox.Text = "";
            optionDTextBox.Text = "";
            explanationTextBox.Text = "";
            optionARadioButton.Checked = true;
        }
    }
}