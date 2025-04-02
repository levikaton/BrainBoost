namespace Quizgame
{
    partial class CoverPage
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
            this.TopPNL = new System.Windows.Forms.Panel();
            this.LogoPNL = new System.Windows.Forms.Panel();
            this.QuizLBL = new System.Windows.Forms.Label();
            this.AutoGenerateBTN = new System.Windows.Forms.Button();
            this.ManualEntryBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopPNL
            // 
            this.TopPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(198)))));
            this.TopPNL.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPNL.Location = new System.Drawing.Point(8, 8);
            this.TopPNL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TopPNL.Name = "TopPNL";
            this.TopPNL.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.TopPNL.Size = new System.Drawing.Size(1230, 72);
            this.TopPNL.TabIndex = 0;
            // 
            // LogoPNL
            // 
            this.LogoPNL.BackgroundImage = global::Quizgame.Properties.Resources.BrainBoostLogo2;
            this.LogoPNL.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPNL.Location = new System.Drawing.Point(8, 80);
            this.LogoPNL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogoPNL.Name = "LogoPNL";
            this.LogoPNL.Size = new System.Drawing.Size(447, 458);
            this.LogoPNL.TabIndex = 1;
            // 
            // QuizLBL
            // 
            this.QuizLBL.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizLBL.Location = new System.Drawing.Point(562, 132);
            this.QuizLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuizLBL.Name = "QuizLBL";
            this.QuizLBL.Size = new System.Drawing.Size(609, 137);
            this.QuizLBL.TabIndex = 2;
            this.QuizLBL.Text = "Quiz Question Entry";
            this.QuizLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutoGenerateBTN
            // 
            this.AutoGenerateBTN.BackColor = System.Drawing.SystemColors.ControlText;
            this.AutoGenerateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoGenerateBTN.Location = new System.Drawing.Point(598, 289);
            this.AutoGenerateBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AutoGenerateBTN.Name = "AutoGenerateBTN";
            this.AutoGenerateBTN.Size = new System.Drawing.Size(236, 49);
            this.AutoGenerateBTN.TabIndex = 3;
            this.AutoGenerateBTN.Text = "AI-Generated Questions";
            this.AutoGenerateBTN.UseVisualStyleBackColor = false;
            this.AutoGenerateBTN.Click += new System.EventHandler(this.AutoGenerateBTN_Click);
            // 
            // ManualEntryBTN
            // 
            this.ManualEntryBTN.BackColor = System.Drawing.SystemColors.ControlText;
            this.ManualEntryBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManualEntryBTN.Location = new System.Drawing.Point(903, 289);
            this.ManualEntryBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ManualEntryBTN.Name = "ManualEntryBTN";
            this.ManualEntryBTN.Size = new System.Drawing.Size(237, 49);
            this.ManualEntryBTN.TabIndex = 4;
            this.ManualEntryBTN.Text = "Manual Entry";
            this.ManualEntryBTN.UseVisualStyleBackColor = false;
            this.ManualEntryBTN.Click += new System.EventHandler(this.ManualEntryBTN_Click);
            // 
            // CoverPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1246, 546);
            this.Controls.Add(this.ManualEntryBTN);
            this.Controls.Add(this.AutoGenerateBTN);
            this.Controls.Add(this.QuizLBL);
            this.Controls.Add(this.LogoPNL);
            this.Controls.Add(this.TopPNL);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CoverPage";
            this.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Text = "CoverPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPNL;
        private System.Windows.Forms.Panel LogoPNL;
        private System.Windows.Forms.Label QuizLBL;
        private System.Windows.Forms.Button AutoGenerateBTN;
        private System.Windows.Forms.Button ManualEntryBTN;
    }
}