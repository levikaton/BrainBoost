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
            this.TopPNL.Location = new System.Drawing.Point(5, 5);
            this.TopPNL.Name = "TopPNL";
            this.TopPNL.Padding = new System.Windows.Forms.Padding(5);
            this.TopPNL.Size = new System.Drawing.Size(821, 47);
            this.TopPNL.TabIndex = 0;
            // 
            // LogoPNL
            // 
            this.LogoPNL.BackgroundImage = global::Quizgame.Properties.Resources.BrainBoostLogo2;
            this.LogoPNL.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPNL.Location = new System.Drawing.Point(5, 52);
            this.LogoPNL.Name = "LogoPNL";
            this.LogoPNL.Size = new System.Drawing.Size(298, 298);
            this.LogoPNL.TabIndex = 1;
            this.LogoPNL.Paint += new System.Windows.Forms.PaintEventHandler(this.LogoPNL_Paint);
            // 
            // QuizLBL
            // 
            this.QuizLBL.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizLBL.Location = new System.Drawing.Point(375, 86);
            this.QuizLBL.Name = "QuizLBL";
            this.QuizLBL.Size = new System.Drawing.Size(406, 89);
            this.QuizLBL.TabIndex = 2;
            this.QuizLBL.Text = "Quiz Question Entry";
            this.QuizLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutoGenerateBTN
            // 
            this.AutoGenerateBTN.BackColor = System.Drawing.SystemColors.ControlText;
            this.AutoGenerateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoGenerateBTN.Location = new System.Drawing.Point(399, 188);
            this.AutoGenerateBTN.Name = "AutoGenerateBTN";
            this.AutoGenerateBTN.Size = new System.Drawing.Size(157, 32);
            this.AutoGenerateBTN.TabIndex = 3;
            this.AutoGenerateBTN.Text = "AI-Generated Questions";
            this.AutoGenerateBTN.UseVisualStyleBackColor = false;
            // 
            // ManualEntryBTN
            // 
            this.ManualEntryBTN.BackColor = System.Drawing.SystemColors.ControlText;
            this.ManualEntryBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManualEntryBTN.Location = new System.Drawing.Point(602, 188);
            this.ManualEntryBTN.Name = "ManualEntryBTN";
            this.ManualEntryBTN.Size = new System.Drawing.Size(158, 32);
            this.ManualEntryBTN.TabIndex = 4;
            this.ManualEntryBTN.Text = "Manual Entry";
            this.ManualEntryBTN.UseVisualStyleBackColor = false;
            this.ManualEntryBTN.Click += new System.EventHandler(this.ManualEntryBTN_Click);
            // 
            // CoverPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(831, 355);
            this.Controls.Add(this.ManualEntryBTN);
            this.Controls.Add(this.AutoGenerateBTN);
            this.Controls.Add(this.QuizLBL);
            this.Controls.Add(this.LogoPNL);
            this.Controls.Add(this.TopPNL);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoverPage";
            this.Padding = new System.Windows.Forms.Padding(5);
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