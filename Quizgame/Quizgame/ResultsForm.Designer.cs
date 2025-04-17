namespace Quizgame
{
    partial class ResultsForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.progressBarScore = new System.Windows.Forms.ProgressBar();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.lblAvgTime = new System.Windows.Forms.Label();
            this.lblAvgTimeValue = new System.Windows.Forms.Label();
            this.lblPerformanceSummary = new System.Windows.Forms.Label();
            this.lblTrophy = new System.Windows.Forms.Label();
            this.lblImprovementTips = new System.Windows.Forms.Label();
            this.lstImprovementTips = new System.Windows.Forms.ListBox();
            this.lblWrongQuestions = new System.Windows.Forms.Label();
            this.lblReviewRound = new System.Windows.Forms.Label();
            this.btnReviewWrong = new System.Windows.Forms.Button();
            this.btnStartNewQuiz = new System.Windows.Forms.Button();
            this.btnCopyResults = new System.Windows.Forms.Button();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(222, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quiz Results!";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(54, 66);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 20);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreValue.Location = new System.Drawing.Point(111, 66);
            this.lblScoreValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(34, 20);
            this.lblScoreValue.TabIndex = 2;
            this.lblScoreValue.Text = "0/0";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(161, 66);
            this.lblPercentage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(49, 20);
            this.lblPercentage.TabIndex = 3;
            this.lblPercentage.Text = "0.0%";
            // 
            // progressBarScore
            // 
            this.progressBarScore.Location = new System.Drawing.Point(226, 66);
            this.progressBarScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBarScore.Name = "progressBarScore";
            this.progressBarScore.Size = new System.Drawing.Size(333, 19);
            this.progressBarScore.TabIndex = 4;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(54, 102);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(86, 20);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Total Time:";
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeValue.Location = new System.Drawing.Point(142, 102);
            this.lblTimeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(49, 20);
            this.lblTimeValue.TabIndex = 6;
            this.lblTimeValue.Text = "00:00";
            // 
            // lblAvgTime
            // 
            this.lblAvgTime.AutoSize = true;
            this.lblAvgTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgTime.Location = new System.Drawing.Point(210, 102);
            this.lblAvgTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvgTime.Name = "lblAvgTime";
            this.lblAvgTime.Size = new System.Drawing.Size(174, 20);
            this.lblAvgTime.TabIndex = 7;
            this.lblAvgTime.Text = "Avg Time Per Question:";
            // 
            // lblAvgTimeValue
            // 
            this.lblAvgTimeValue.AutoSize = true;
            this.lblAvgTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgTimeValue.Location = new System.Drawing.Point(382, 102);
            this.lblAvgTimeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvgTimeValue.Name = "lblAvgTimeValue";
            this.lblAvgTimeValue.Size = new System.Drawing.Size(49, 20);
            this.lblAvgTimeValue.TabIndex = 8;
            this.lblAvgTimeValue.Text = "00:00";
            // 
            // lblPerformanceSummary
            // 
            this.lblPerformanceSummary.AutoSize = true;
            this.lblPerformanceSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerformanceSummary.Location = new System.Drawing.Point(54, 137);
            this.lblPerformanceSummary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerformanceSummary.Name = "lblPerformanceSummary";
            this.lblPerformanceSummary.Size = new System.Drawing.Size(189, 20);
            this.lblPerformanceSummary.TabIndex = 9;
            this.lblPerformanceSummary.Text = "Nice effort! Keep it up!";
            // 
            // lblTrophy
            // 
            this.lblTrophy.Font = new System.Drawing.Font("Segoe UI Emoji", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrophy.Location = new System.Drawing.Point(476, 86);
            this.lblTrophy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrophy.Name = "lblTrophy";
            this.lblTrophy.Size = new System.Drawing.Size(83, 81);
            this.lblTrophy.TabIndex = 10;
            this.lblTrophy.Text = "🏆";
            this.lblTrophy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImprovementTips
            // 
            this.lblImprovementTips.AutoSize = true;
            this.lblImprovementTips.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImprovementTips.Location = new System.Drawing.Point(54, 173);
            this.lblImprovementTips.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImprovementTips.Name = "lblImprovementTips";
            this.lblImprovementTips.Size = new System.Drawing.Size(121, 20);
            this.lblImprovementTips.TabIndex = 11;
            this.lblImprovementTips.Text = "Tips to Improve:";
            // 
            // lstImprovementTips
            // 
            this.lstImprovementTips.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstImprovementTips.FormattingEnabled = true;
            this.lstImprovementTips.ItemHeight = 15;
            this.lstImprovementTips.Location = new System.Drawing.Point(57, 196);
            this.lstImprovementTips.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstImprovementTips.Name = "lstImprovementTips";
            this.lstImprovementTips.Size = new System.Drawing.Size(335, 64);
            this.lstImprovementTips.TabIndex = 12;
            // 
            // lblWrongQuestions
            // 
            this.lblWrongQuestions.AutoSize = true;
            this.lblWrongQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongQuestions.Location = new System.Drawing.Point(54, 280);
            this.lblWrongQuestions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWrongQuestions.Name = "lblWrongQuestions";
            this.lblWrongQuestions.Size = new System.Drawing.Size(258, 18);
            this.lblWrongQuestions.TabIndex = 13;
            this.lblWrongQuestions.Text = "You answered 0 questions incorrectly.";
            // 
            // lblReviewRound
            // 
            this.lblReviewRound.AutoSize = true;
            this.lblReviewRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewRound.Location = new System.Drawing.Point(340, 280);
            this.lblReviewRound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReviewRound.Name = "lblReviewRound";
            this.lblReviewRound.Size = new System.Drawing.Size(132, 18);
            this.lblReviewRound.TabIndex = 14;
            this.lblReviewRound.Text = "Review Round: 0/2";
            this.lblReviewRound.Visible = false;
            // 
            // btnReviewWrong
            // 
            this.btnReviewWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviewWrong.Location = new System.Drawing.Point(57, 320);
            this.btnReviewWrong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReviewWrong.Name = "btnReviewWrong";
            this.btnReviewWrong.Size = new System.Drawing.Size(167, 26);
            this.btnReviewWrong.TabIndex = 15;
            this.btnReviewWrong.Text = "Review Wrong Questions";
            this.btnReviewWrong.UseVisualStyleBackColor = true;
            this.btnReviewWrong.Click += new System.EventHandler(this.btnReviewWrong_Click);
            // 
            // btnStartNewQuiz
            // 
            this.btnStartNewQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartNewQuiz.Location = new System.Drawing.Point(377, 320);
            this.btnStartNewQuiz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartNewQuiz.Name = "btnStartNewQuiz";
            this.btnStartNewQuiz.Size = new System.Drawing.Size(167, 26);
            this.btnStartNewQuiz.TabIndex = 16;
            this.btnStartNewQuiz.Text = "Start New Quiz";
            this.btnStartNewQuiz.UseVisualStyleBackColor = true;
            this.btnStartNewQuiz.Click += new System.EventHandler(this.btnStartNewQuiz_Click);
            // 
            // btnCopyResults
            // 
            this.btnCopyResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyResults.Location = new System.Drawing.Point(244, 320);
            this.btnCopyResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCopyResults.Name = "btnCopyResults";
            this.btnCopyResults.Size = new System.Drawing.Size(113, 26);
            this.btnCopyResults.TabIndex = 17;
            this.btnCopyResults.Text = "Copy Results";
            this.btnCopyResults.UseVisualStyleBackColor = true;
            this.btnCopyResults.Click += new System.EventHandler(this.btnCopyResults_Click);
            // 
            // chartPanel
            // 
            this.chartPanel.Location = new System.Drawing.Point(442, 169);
            this.chartPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(117, 114);
            this.chartPanel.TabIndex = 18;
            this.chartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.chartPanel_Paint);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 402);
            this.Controls.Add(this.chartPanel);
            this.Controls.Add(this.btnCopyResults);
            this.Controls.Add(this.btnStartNewQuiz);
            this.Controls.Add(this.btnReviewWrong);
            this.Controls.Add(this.lblReviewRound);
            this.Controls.Add(this.lblWrongQuestions);
            this.Controls.Add(this.lstImprovementTips);
            this.Controls.Add(this.lblImprovementTips);
            this.Controls.Add(this.lblTrophy);
            this.Controls.Add(this.lblPerformanceSummary);
            this.Controls.Add(this.lblAvgTimeValue);
            this.Controls.Add(this.lblAvgTime);
            this.Controls.Add(this.lblTimeValue);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.progressBarScore);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblScoreValue);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quiz Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreValue;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.ProgressBar progressBarScore;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Label lblAvgTime;
        private System.Windows.Forms.Label lblAvgTimeValue;
        private System.Windows.Forms.Label lblPerformanceSummary;
        private System.Windows.Forms.Label lblTrophy;
        private System.Windows.Forms.Label lblImprovementTips;
        private System.Windows.Forms.ListBox lstImprovementTips;
        private System.Windows.Forms.Label lblWrongQuestions;
        private System.Windows.Forms.Label lblReviewRound;
        private System.Windows.Forms.Button btnReviewWrong;
        private System.Windows.Forms.Button btnStartNewQuiz;
        private System.Windows.Forms.Button btnCopyResults;
        private System.Windows.Forms.Panel chartPanel;
    }
}