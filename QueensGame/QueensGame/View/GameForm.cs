using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QueensGame.Models;

namespace QueensGame.View
{
    public partial class GameForm : Form
    {
        private ChessPanel[,] chessTiles;
        private Queensboard board;
        private Label infoBlock;
        private static readonly Image QueenImage = Image.FromFile("images/queen.png");
        private int boardSize;
        private static readonly int TileSize = QueenImage.Width;

        public GameForm()
        {
            InitializeComponent();
        }

        public GameForm(int boardSize)
            : this()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.boardSize = boardSize;
            this.board = new Queensboard(boardSize);
            this.chessTiles = new ChessPanel[boardSize, boardSize];
            int length = boardSize * TileSize;
            this.Size = new Size(length + 15, length + 55);
            this.infoBlock = new Label();
            this.infoBlock.AutoSize = true;
            this.infoBlock.Location = new Point(0, length);
            this.infoBlock.Text = "Click on a tile to place a queen.";
            Controls.Add(infoBlock);
            InitializeFormBoard();
        }

        private void InitializeFormBoard()
        {
            Color firstColor = Color.DarkGray;
            Color secondColor = Color.White;

            for (int i = 0; i < boardSize; i++)
                for (int j = 0; j < boardSize; j++)
                {
                    ChessPanel newPanel = new ChessPanel(i, j);
                    newPanel.Size = new Size(TileSize, TileSize);
                    newPanel.Location = new Point(TileSize * i, TileSize * j);

                    newPanel.Click += new EventHandler(this.chessTile_Click);
                    Controls.Add(newPanel);

                    chessTiles[i, j] = newPanel;

                    if (i % 2 == 0)
                        newPanel.BackColor = (j % 2 != 0) ? firstColor : secondColor;
                    else
                        newPanel.BackColor = (j % 2 != 0) ? secondColor : firstColor;
                }


        }

        private void chessTile_Click(object sender, EventArgs e)
        {
            var clickedPanel = sender as ChessPanel;
            int clickedRow = clickedPanel.Row;
            int clickedCol = clickedPanel.Col;

            QueensTurnOutput turnResult = board.GetOutputFromTurn(clickedRow, clickedCol);

            if (turnResult == QueensTurnOutput.Valid || turnResult == QueensTurnOutput.GameCompleted ||
                turnResult == QueensTurnOutput.Lost)
            {
                clickedPanel.BackgroundImage = QueenImage;
            }

            switch (turnResult)
            {
                case QueensTurnOutput.Valid:
                    SetInfoBlockMessage("Queen placed at row " + (clickedRow + 1) + ", column " + (clickedCol + 1), Color.Black);
                    break;
                case QueensTurnOutput.Invalid:
                    SetInfoBlockMessage("There is already a queen on this position!", Color.Black);
                    break;
                case QueensTurnOutput.GameCompleted:
                    SetInfoBlockMessage("Congratulations, you completed the game!", Color.Green);
                    DisableTiles();
                    break;
                case QueensTurnOutput.Lost:
                    SetInfoBlockMessage("You lost!", Color.Red);
                    DisableTiles();
                    break;
            }
        }

        private void SetInfoBlockMessage(string message, Color foreColor)
        {
            infoBlock.ForeColor = foreColor;
            infoBlock.Text = message; 
        }

        private void DisableTiles()
        {
            for (int i = 0; i < boardSize; i++)
                for (int j = 0; j < boardSize; j++)
                    chessTiles[i, j].Click -= this.chessTile_Click;
        }
    }
}
