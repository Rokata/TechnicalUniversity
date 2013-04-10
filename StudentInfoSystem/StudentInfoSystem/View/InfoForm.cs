using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentInfoSystem.View
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        public InfoForm(string text) : this()
        {
            richTextBox.Text = text;
            btnColor.Image = Image.FromFile(@"icons/image.png");
            saveButton.Image = Image.FromFile(@"icons/save.gif");
            btnFont.Image = Image.FromFile(@"icons/font.png");
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox.SelectedText == "")
                {
                    richTextBox.Font = fontDialog.Font;
                }
                else
                {
                    richTextBox.SelectionFont = fontDialog.Font;
                }
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox.SelectedText == "")
                {
                    richTextBox.ForeColor = colorDialog.Color;
                }
                else
                {
                    richTextBox.SelectionColor = colorDialog.Color;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = "*.rtf";
            saveFileDialog.Filter = "RTF Files|*.rtf";
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && (saveFileDialog.FileName.Length > 0))
            {
                try
                {
                    // Save the contents of the RichTextBox into the file.
                    richTextBox.SaveFile(saveFileDialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Файлът не беше съхранен, поради грешка в записа!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
