using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QueensGame.View
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void confirmBoardButton_Click(object sender, EventArgs e)
        {
            if (boardSizeList.SelectedIndex == -1)
            {
                MessageBox.Show("You must choose value from the list!");
                return;
            }

            int size = int.Parse(boardSizeList.Text);

            GameForm gameForm = new GameForm(size);
            gameForm.Show();
        }
    }
}
