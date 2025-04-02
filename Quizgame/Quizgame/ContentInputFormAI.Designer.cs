namespace Quizgame
{
    partial class ContentInputFormAI
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
            ((System.ComponentModel.ISupportInitialize)(this.questionCountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // contentTextBox
            // 
            this.contentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.contentTextBox.Location = new System.Drawing.Point(73, 74);
            this.contentTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentTextBox.Size = new System.Drawing.Size(641, 374);
            this.contentTextBox.TabIndex = 0;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(59, 41);
            this.instructionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(271, 29);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Paste your content here:";
            // 
            // questionsLabel
            // 
            this.questionsLabel.AutoSize = true;
            this.questionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionsLabel.Location = new System.Drawing.Point(59, 479);
            this.questionsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.questionsLabel.Name = "questionsLabel";
            this.questionsLabel.Size = new System.Drawing.Size(248, 29);
            this.questionsLabel.TabIndex = 2;
            this.questionsLabel.Text = "Number of questions :";
            // 
            // questionCountUpDown
            // 
            this.questionCountUpDown.Location = new System.Drawing.Point(64, 512);
            this.questionCountUpDown.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.questionCountUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.questionCountUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.questionCountUpDown.Name = "questionCountUpDown";
            this.questionCountUpDown.Size = new System.Drawing.Size(187, 35);
            this.questionCountUpDown.TabIndex = 3;
            this.questionCountUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.questionCountUpDown.ValueChanged += new System.EventHandler(this.questionCountUpDown_ValueChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(364, 479);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(380, 59);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Generate Questions";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ContentInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 567);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.questionCountUpDown);
            this.Controls.Add(this.questionsLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.contentTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ContentInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Content Input";
            ((System.ComponentModel.ISupportInitialize)(this.questionCountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label questionsLabel;
        private System.Windows.Forms.NumericUpDown questionCountUpDown;
        private System.Windows.Forms.Button submitButton;
    }
}