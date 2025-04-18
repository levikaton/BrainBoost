using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class Prompt
{
    public static string ShowDialog(string text, string caption)
    {
        Form prompt = new Form()
        {
            Width = 300,
            Height = 150,
            Text = caption,
            StartPosition = FormStartPosition.CenterScreen
        };

        Label textLabel = new Label() { Left = 10, Top = 10, Text = text, AutoSize = true };
        TextBox inputBox = new TextBox() { Left = 10, Top = 40, Width = 260 };
        Button confirmation = new Button() { Text = "OK", Left = 190, Width = 80, Top = 70, DialogResult = DialogResult.OK };

        prompt.Controls.Add(textLabel);
        prompt.Controls.Add(inputBox);
        prompt.Controls.Add(confirmation);
        prompt.AcceptButton = confirmation;

        return prompt.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(inputBox.Text)
            ? inputBox.Text
            : "Anonymous";
    }
}
