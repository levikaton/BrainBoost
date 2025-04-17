namespace Quizgame
{
    partial class QuizForm
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.explanationTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.reviewButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionLabel.Location = new System.Drawing.Point(13, 13);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(932, 84);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "label1";
            // 
            // scoreLabel
            // 
            this.scoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreLabel.Location = new System.Drawing.Point(12, 108);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(932, 41);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "label2";
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(12, 170);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(932, 54);
            this.btnA.TabIndex = 2;
            this.btnA.Tag = "a";
            this.btnA.Text = "button1";
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(13, 242);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(932, 54);
            this.btnB.TabIndex = 3;
            this.btnB.Tag = "b";
            this.btnB.Text = "button2";
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(13, 302);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(932, 54);
            this.btnC.TabIndex = 4;
            this.btnC.Tag = "c";
            this.btnC.Text = "button3";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(13, 373);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(932, 54);
            this.btnD.TabIndex = 5;
            this.btnD.Tag = "d";
            this.btnD.Text = "button4";
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.feedbackLabel.Location = new System.Drawing.Point(13, 450);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(932, 49);
            this.feedbackLabel.TabIndex = 6;
            this.feedbackLabel.Text = "label2";
            // 
            // explanationTextBox
            // 
            this.explanationTextBox.Location = new System.Drawing.Point(13, 502);
            this.explanationTextBox.Multiline = true;
            this.explanationTextBox.Name = "explanationTextBox";
            this.explanationTextBox.ReadOnly = true;
            this.explanationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.explanationTextBox.Size = new System.Drawing.Size(932, 78);
            this.explanationTextBox.TabIndex = 7;
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(697, 656);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(237, 34);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = "Next Question";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // reviewButton
            // 
            this.reviewButton.Location = new System.Drawing.Point(38, 656);
            this.reviewButton.Name = "reviewButton";
            this.reviewButton.Size = new System.Drawing.Size(250, 34);
            this.reviewButton.TabIndex = 9;
            this.reviewButton.Text = "Review Wrong Questions";
            this.reviewButton.UseVisualStyleBackColor = true;
            this.reviewButton.Visible = false;
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(697, 656);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(237, 34);
            this.restartButton.TabIndex = 10;
            this.restartButton.Text = "Start New Quiz";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Visible = false;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(38, 600);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(83, 27);
            this.timerLabel.TabIndex = 11;
            this.timerLabel.Text = "Time: 00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.reviewButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.explanationTextBox);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.questionLabel);
            //
            // Add click event handlers for answer buttons
            //
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            this.reviewButton.Click += new System.EventHandler(this.reviewButton_Click);
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);

            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.TextBox explanationTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button reviewButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label timerLabel;

    }
}