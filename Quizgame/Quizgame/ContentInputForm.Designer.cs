namespace Quizgame
{
    partial class ContentInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.questionsLabel = new System.Windows.Forms.Label();
            this.questionCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.submitButton = new System.Windows.Forms.Button();
            this.inputModePanel = new System.Windows.Forms.Panel();
            this.formRadioButton = new System.Windows.Forms.RadioButton();
            this.jsonRadioButton = new System.Windows.Forms.RadioButton();
            this.jsonInputPanel = new System.Windows.Forms.Panel();
            this.formInputPanel = new System.Windows.Forms.Panel();
            this.questionsListView = new System.Windows.Forms.ListView();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.deleteQuestionButton = new System.Windows.Forms.Button();
            this.editQuestionButton = new System.Windows.Forms.Button();
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.formFieldsPanel = new System.Windows.Forms.Panel();
            this.explanationLabel = new System.Windows.Forms.Label();
            this.explanationTextBox = new System.Windows.Forms.TextBox();
            this.correctAnswerGroupBox = new System.Windows.Forms.GroupBox();
            this.optionDRadioButton = new System.Windows.Forms.RadioButton();
            this.optionCRadioButton = new System.Windows.Forms.RadioButton();
            this.optionBRadioButton = new System.Windows.Forms.RadioButton();
            this.optionARadioButton = new System.Windows.Forms.RadioButton();
            this.optionDLabel = new System.Windows.Forms.Label();
            this.optionDTextBox = new System.Windows.Forms.TextBox();
            this.optionCLabel = new System.Windows.Forms.Label();
            this.optionCTextBox = new System.Windows.Forms.TextBox();
            this.optionBLabel = new System.Windows.Forms.Label();
            this.optionBTextBox = new System.Windows.Forms.TextBox();
            this.optionALabel = new System.Windows.Forms.Label();
            this.optionATextBox = new System.Windows.Forms.TextBox();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.questionCountUpDown)).BeginInit();
            this.inputModePanel.SuspendLayout();
            this.jsonInputPanel.SuspendLayout();
            this.formInputPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.formFieldsPanel.SuspendLayout();
            this.correctAnswerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentTextBox
            // 
            this.contentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.contentTextBox.Location = new System.Drawing.Point(10, 10);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentTextBox.Size = new System.Drawing.Size(792, 317);
            this.contentTextBox.TabIndex = 0;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.instructionLabel.Location = new System.Drawing.Point(12, 45);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(224, 25);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Paste your content here:";
            // 
            // questionsLabel
            // 
            this.questionsLabel.AutoSize = true;
            this.questionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.questionsLabel.Location = new System.Drawing.Point(36, 355);
            this.questionsLabel.Name = "questionsLabel";
            this.questionsLabel.Size = new System.Drawing.Size(267, 25);
            this.questionsLabel.TabIndex = 2;
            this.questionsLabel.Text = "Number of questions (10-15):";
            this.questionsLabel.Visible = false;
            // 
            // questionCountUpDown
            // 
            this.questionCountUpDown.Location = new System.Drawing.Point(84, 410);
            this.questionCountUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.questionCountUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.questionCountUpDown.Name = "questionCountUpDown";
            this.questionCountUpDown.Size = new System.Drawing.Size(60, 26);
            this.questionCountUpDown.TabIndex = 3;
            this.questionCountUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.questionCountUpDown.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(502, 580);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(300, 40);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Start Quiz";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // inputModePanel
            // 
            this.inputModePanel.Controls.Add(this.formRadioButton);
            this.inputModePanel.Controls.Add(this.jsonRadioButton);
            this.inputModePanel.Location = new System.Drawing.Point(12, 12);
            this.inputModePanel.Name = "inputModePanel";
            this.inputModePanel.Size = new System.Drawing.Size(792, 30);
            this.inputModePanel.TabIndex = 5;
            // 
            // formRadioButton
            // 
            this.formRadioButton.AutoSize = true;
            this.formRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.formRadioButton.Location = new System.Drawing.Point(200, 3);
            this.formRadioButton.Name = "formRadioButton";
            this.formRadioButton.Size = new System.Drawing.Size(176, 22);
            this.formRadioButton.TabIndex = 1;
            this.formRadioButton.Text = "Form-Based Questions";
            this.formRadioButton.UseVisualStyleBackColor = true;
            this.formRadioButton.CheckedChanged += new System.EventHandler(this.formRadioButton_CheckedChanged);
            // 
            // jsonRadioButton
            // 
            this.jsonRadioButton.AutoSize = true;
            this.jsonRadioButton.Checked = true;
            this.jsonRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.jsonRadioButton.Location = new System.Drawing.Point(3, 3);
            this.jsonRadioButton.Name = "jsonRadioButton";
            this.jsonRadioButton.Size = new System.Drawing.Size(174, 22);
            this.jsonRadioButton.TabIndex = 0;
            this.jsonRadioButton.TabStop = true;
            this.jsonRadioButton.Text = "JSON Format Questions";
            this.jsonRadioButton.UseVisualStyleBackColor = true;
            this.jsonRadioButton.CheckedChanged += new System.EventHandler(this.jsonRadioButton_CheckedChanged);
            // 
            // jsonInputPanel
            // 
            this.jsonInputPanel.Controls.Add(this.contentTextBox);
            this.jsonInputPanel.Location = new System.Drawing.Point(12, 73);
            this.jsonInputPanel.Name = "jsonInputPanel";
            this.jsonInputPanel.Size = new System.Drawing.Size(814, 330);
            this.jsonInputPanel.TabIndex = 6;
            // 
            // formInputPanel
            // 
            this.formInputPanel.Controls.Add(this.questionsListView);
            this.formInputPanel.Controls.Add(this.buttonsPanel);
            this.formInputPanel.Controls.Add(this.formFieldsPanel);
            this.formInputPanel.Location = new System.Drawing.Point(12, 73);
            this.formInputPanel.Name = "formInputPanel";
            this.formInputPanel.Size = new System.Drawing.Size(814, 491);
            this.formInputPanel.TabIndex = 7;
            // 
            // questionsListView
            // 
            this.questionsListView.HideSelection = false;
            this.questionsListView.Location = new System.Drawing.Point(4, 321);
            this.questionsListView.Name = "questionsListView";
            this.questionsListView.Size = new System.Drawing.Size(807, 133);
            this.questionsListView.TabIndex = 2;
            this.questionsListView.UseCompatibleStateImageBehavior = false;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.clearAllButton);
            this.buttonsPanel.Controls.Add(this.deleteQuestionButton);
            this.buttonsPanel.Controls.Add(this.editQuestionButton);
            this.buttonsPanel.Controls.Add(this.addQuestionButton);
            this.buttonsPanel.Location = new System.Drawing.Point(4, 454);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(807, 37);
            this.buttonsPanel.TabIndex = 1;
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(632, 3);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(172, 31);
            this.clearAllButton.TabIndex = 3;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            // 
            // deleteQuestionButton
            // 
            this.deleteQuestionButton.Enabled = false;
            this.deleteQuestionButton.Location = new System.Drawing.Point(423, 3);
            this.deleteQuestionButton.Name = "deleteQuestionButton";
            this.deleteQuestionButton.Size = new System.Drawing.Size(172, 31);
            this.deleteQuestionButton.TabIndex = 2;
            this.deleteQuestionButton.Text = "Delete Question";
            this.deleteQuestionButton.UseVisualStyleBackColor = true;
            // 
            // editQuestionButton
            // 
            this.editQuestionButton.Enabled = false;
            this.editQuestionButton.Location = new System.Drawing.Point(215, 3);
            this.editQuestionButton.Name = "editQuestionButton";
            this.editQuestionButton.Size = new System.Drawing.Size(172, 31);
            this.editQuestionButton.TabIndex = 1;
            this.editQuestionButton.Text = "Edit Question";
            this.editQuestionButton.UseVisualStyleBackColor = true;
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.Location = new System.Drawing.Point(3, 3);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(172, 31);
            this.addQuestionButton.TabIndex = 0;
            this.addQuestionButton.Text = "Add Question";
            this.addQuestionButton.UseVisualStyleBackColor = true;
            // 
            // formFieldsPanel
            // 
            this.formFieldsPanel.Controls.Add(this.explanationLabel);
            this.formFieldsPanel.Controls.Add(this.explanationTextBox);
            this.formFieldsPanel.Controls.Add(this.correctAnswerGroupBox);
            this.formFieldsPanel.Controls.Add(this.optionDLabel);
            this.formFieldsPanel.Controls.Add(this.optionDTextBox);
            this.formFieldsPanel.Controls.Add(this.optionCLabel);
            this.formFieldsPanel.Controls.Add(this.optionCTextBox);
            this.formFieldsPanel.Controls.Add(this.optionBLabel);
            this.formFieldsPanel.Controls.Add(this.optionBTextBox);
            this.formFieldsPanel.Controls.Add(this.optionALabel);
            this.formFieldsPanel.Controls.Add(this.optionATextBox);
            this.formFieldsPanel.Controls.Add(this.questionTextLabel);
            this.formFieldsPanel.Controls.Add(this.questionTextBox);
            this.formFieldsPanel.Location = new System.Drawing.Point(3, 3);
            this.formFieldsPanel.Name = "formFieldsPanel";
            this.formFieldsPanel.Size = new System.Drawing.Size(808, 312);
            this.formFieldsPanel.TabIndex = 0;
            // 
            // explanationLabel
            // 
            this.explanationLabel.AutoSize = true;
            this.explanationLabel.Location = new System.Drawing.Point(4, 230);
            this.explanationLabel.Name = "explanationLabel";
            this.explanationLabel.Size = new System.Drawing.Size(90, 20);
            this.explanationLabel.TabIndex = 12;
            this.explanationLabel.Text = "Explanation";
            // 
            // explanationTextBox
            // 
            this.explanationTextBox.Location = new System.Drawing.Point(8, 253);
            this.explanationTextBox.Multiline = true;
            this.explanationTextBox.Name = "explanationTextBox";
            this.explanationTextBox.Size = new System.Drawing.Size(797, 56);
            this.explanationTextBox.TabIndex = 11;
            // 
            // correctAnswerGroupBox
            // 
            this.correctAnswerGroupBox.Controls.Add(this.optionDRadioButton);
            this.correctAnswerGroupBox.Controls.Add(this.optionCRadioButton);
            this.correctAnswerGroupBox.Controls.Add(this.optionBRadioButton);
            this.correctAnswerGroupBox.Controls.Add(this.optionARadioButton);
            this.correctAnswerGroupBox.Location = new System.Drawing.Point(493, 111);
            this.correctAnswerGroupBox.Name = "correctAnswerGroupBox";
            this.correctAnswerGroupBox.Size = new System.Drawing.Size(312, 106);
            this.correctAnswerGroupBox.TabIndex = 10;
            this.correctAnswerGroupBox.TabStop = false;
            this.correctAnswerGroupBox.Text = "Correct Answer";
            // 
            // optionDRadioButton
            // 
            this.optionDRadioButton.AutoSize = true;
            this.optionDRadioButton.Location = new System.Drawing.Point(200, 66);
            this.optionDRadioButton.Name = "optionDRadioButton";
            this.optionDRadioButton.Size = new System.Drawing.Size(94, 24);
            this.optionDRadioButton.TabIndex = 3;
            this.optionDRadioButton.TabStop = true;
            this.optionDRadioButton.Text = "Option D";
            this.optionDRadioButton.UseVisualStyleBackColor = true;
            // 
            // optionCRadioButton
            // 
            this.optionCRadioButton.AutoSize = true;
            this.optionCRadioButton.Location = new System.Drawing.Point(16, 66);
            this.optionCRadioButton.Name = "optionCRadioButton";
            this.optionCRadioButton.Size = new System.Drawing.Size(94, 24);
            this.optionCRadioButton.TabIndex = 2;
            this.optionCRadioButton.TabStop = true;
            this.optionCRadioButton.Text = "Option C";
            this.optionCRadioButton.UseVisualStyleBackColor = true;
            // 
            // optionBRadioButton
            // 
            this.optionBRadioButton.AutoSize = true;
            this.optionBRadioButton.Location = new System.Drawing.Point(200, 25);
            this.optionBRadioButton.Name = "optionBRadioButton";
            this.optionBRadioButton.Size = new System.Drawing.Size(94, 24);
            this.optionBRadioButton.TabIndex = 1;
            this.optionBRadioButton.TabStop = true;
            this.optionBRadioButton.Text = "Option B";
            this.optionBRadioButton.UseVisualStyleBackColor = true;
            // 
            // optionARadioButton
            // 
            this.optionARadioButton.AutoSize = true;
            this.optionARadioButton.Location = new System.Drawing.Point(16, 25);
            this.optionARadioButton.Name = "optionARadioButton";
            this.optionARadioButton.Size = new System.Drawing.Size(94, 24);
            this.optionARadioButton.TabIndex = 0;
            this.optionARadioButton.TabStop = true;
            this.optionARadioButton.Text = "Option A";
            this.optionARadioButton.UseVisualStyleBackColor = true;
            // 
            // optionDLabel
            // 
            this.optionDLabel.AutoSize = true;
            this.optionDLabel.Location = new System.Drawing.Point(4, 177);
            this.optionDLabel.Name = "optionDLabel";
            this.optionDLabel.Size = new System.Drawing.Size(74, 20);
            this.optionDLabel.TabIndex = 9;
            this.optionDLabel.Text = "Option D";
            // 
            // optionDTextBox
            // 
            this.optionDTextBox.Location = new System.Drawing.Point(84, 177);
            this.optionDTextBox.Name = "optionDTextBox";
            this.optionDTextBox.Size = new System.Drawing.Size(383, 26);
            this.optionDTextBox.TabIndex = 8;
            // 
            // optionCLabel
            // 
            this.optionCLabel.AutoSize = true;
            this.optionCLabel.Location = new System.Drawing.Point(4, 145);
            this.optionCLabel.Name = "optionCLabel";
            this.optionCLabel.Size = new System.Drawing.Size(74, 20);
            this.optionCLabel.TabIndex = 7;
            this.optionCLabel.Text = "Option C";
            // 
            // optionCTextBox
            // 
            this.optionCTextBox.Location = new System.Drawing.Point(84, 145);
            this.optionCTextBox.Name = "optionCTextBox";
            this.optionCTextBox.Size = new System.Drawing.Size(383, 26);
            this.optionCTextBox.TabIndex = 6;
            // 
            // optionBLabel
            // 
            this.optionBLabel.AutoSize = true;
            this.optionBLabel.Location = new System.Drawing.Point(4, 113);
            this.optionBLabel.Name = "optionBLabel";
            this.optionBLabel.Size = new System.Drawing.Size(74, 20);
            this.optionBLabel.TabIndex = 5;
            this.optionBLabel.Text = "Option B";
            // 
            // optionBTextBox
            // 
            this.optionBTextBox.Location = new System.Drawing.Point(84, 113);
            this.optionBTextBox.Name = "optionBTextBox";
            this.optionBTextBox.Size = new System.Drawing.Size(383, 26);
            this.optionBTextBox.TabIndex = 4;
            // 
            // optionALabel
            // 
            this.optionALabel.AutoSize = true;
            this.optionALabel.Location = new System.Drawing.Point(4, 81);
            this.optionALabel.Name = "optionALabel";
            this.optionALabel.Size = new System.Drawing.Size(74, 20);
            this.optionALabel.TabIndex = 3;
            this.optionALabel.Text = "Option A";
            // 
            // optionATextBox
            // 
            this.optionATextBox.Location = new System.Drawing.Point(84, 81);
            this.optionATextBox.Name = "optionATextBox";
            this.optionATextBox.Size = new System.Drawing.Size(383, 26);
            this.optionATextBox.TabIndex = 2;
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Location = new System.Drawing.Point(4, 8);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(73, 20);
            this.questionTextLabel.TabIndex = 1;
            this.questionTextLabel.Text = "Question";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(8, 31);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(797, 44);
            this.questionTextBox.TabIndex = 0;
            // 
            // ContentInputForm
            // 
            this.ClientSize = new System.Drawing.Size(865, 632);
            this.Controls.Add(this.formInputPanel);
            this.Controls.Add(this.jsonInputPanel);
            this.Controls.Add(this.inputModePanel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.questionCountUpDown);
            this.Controls.Add(this.questionsLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "ContentInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Content Input";
            ((System.ComponentModel.ISupportInitialize)(this.questionCountUpDown)).EndInit();
            this.inputModePanel.ResumeLayout(false);
            this.inputModePanel.PerformLayout();
            this.jsonInputPanel.ResumeLayout(false);
            this.jsonInputPanel.PerformLayout();
            this.formInputPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.formFieldsPanel.ResumeLayout(false);
            this.formFieldsPanel.PerformLayout();
            this.correctAnswerGroupBox.ResumeLayout(false);
            this.correctAnswerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label questionsLabel;
        private System.Windows.Forms.NumericUpDown questionCountUpDown;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Panel inputModePanel;
        private System.Windows.Forms.RadioButton formRadioButton;
        private System.Windows.Forms.RadioButton jsonRadioButton;
        private System.Windows.Forms.Panel jsonInputPanel;
        private System.Windows.Forms.Panel formInputPanel;
        private System.Windows.Forms.Panel formFieldsPanel;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Label optionALabel;
        private System.Windows.Forms.TextBox optionATextBox;
        private System.Windows.Forms.Label optionBLabel;
        private System.Windows.Forms.TextBox optionBTextBox;
        private System.Windows.Forms.Label optionCLabel;
        private System.Windows.Forms.TextBox optionCTextBox;
        private System.Windows.Forms.Label optionDLabel;
        private System.Windows.Forms.TextBox optionDTextBox;
        private System.Windows.Forms.GroupBox correctAnswerGroupBox;
        private System.Windows.Forms.RadioButton optionDRadioButton;
        private System.Windows.Forms.RadioButton optionCRadioButton;
        private System.Windows.Forms.RadioButton optionBRadioButton;
        private System.Windows.Forms.RadioButton optionARadioButton;
        private System.Windows.Forms.Label explanationLabel;
        private System.Windows.Forms.TextBox explanationTextBox;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button deleteQuestionButton;
        private System.Windows.Forms.Button editQuestionButton;
        private System.Windows.Forms.Button addQuestionButton;
        private System.Windows.Forms.ListView questionsListView;
    }
}