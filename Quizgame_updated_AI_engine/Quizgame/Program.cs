using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizgame
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var contentForm = new ContentInputForm())
            {
                if (contentForm.ShowDialog() == DialogResult.OK && contentForm.GeneratedQuestions != null)
                {
                    Application.Run(new QuizForm(contentForm.GeneratedQuestions));
                }
            }
        }
    }
}
