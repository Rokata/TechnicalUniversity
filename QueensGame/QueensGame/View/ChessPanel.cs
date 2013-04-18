using System;
using System.Windows.Forms;

namespace QueensGame.View
{
    class ChessPanel : Panel
    {
        private int row;
        private int col;

        public ChessPanel(int row, int col) : base() 
        {
            this.row = row;
            this.col = col;
        }

        public int Row
        {
            get { return this.row; }
        }

        public int Col
        {
            get { return this.col; }
        }
    }
}
