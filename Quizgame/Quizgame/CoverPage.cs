using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizgame
{
    public partial class CoverPage : Form
    {
        public CoverPage()
        {
            InitializeComponent();
        }

        private void ManualEntryBTN_Click(object sender, EventArgs e)
        {
            using (var contentForm = new ContentInputForm())
            {
                if (contentForm.ShowDialog() == DialogResult.OK && contentForm.GeneratedQuestions != null)
                {
                    var quizForm = new QuizForm(contentForm.GeneratedQuestions);
                    quizForm.ShowDialog();
                }
            }
        }

        private void AutoGenerateBTN_Click(object sender, EventArgs e)
        {

            using (var contentForm = new ContentInputFormAI())
            {
                if (contentForm.ShowDialog() == DialogResult.OK && contentForm.GeneratedQuestions != null)
                {
                    var quizForm = new QuizForm(contentForm.GeneratedQuestions);
                    quizForm.ShowDialog();  // Show the quiz form modally
                }
            }
        }

        private void ViewScoresBTN_Click(object sender, EventArgs e)
        {
            var scoreForm = new ScoreForm();
            scoreForm.ShowDialog();
        }
    }
}
