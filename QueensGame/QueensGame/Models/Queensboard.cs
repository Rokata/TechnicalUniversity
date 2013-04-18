using System;

namespace QueensGame.Models
{
    public class Queensboard
    {
        private int size;
        private bool[,] boardPositions;
        private bool[,] queensPositions;
        private bool[] rowsUnplayable;
        private bool[] colsUnplayable;
        private int queensPlaced;

        public Queensboard(int size)
        {
            this.size = size;
            this.queensPlaced = 0;
            this.boardPositions = new bool[size, size];
            this.queensPositions = new bool[size, size];
            this.rowsUnplayable = new bool[size];
            this.colsUnplayable = new bool[size];
        }

        public bool this[int i, int j]
        {
            get { return boardPositions[i, j]; }
            set { boardPositions[i, j] = value; }
        }

        public bool IsCompleted
        {
            get { return (queensPlaced == size); }
        }

        private bool HasOptionsLeft()
        {
            bool hasPlayableTile = false;

            for (int row = 0; row < size; row++)
            {
                if (!rowsUnplayable[row])
                {
                    for (int col = 0; col < size; col++)
                        if (!this[row, col])
                        {
                            hasPlayableTile = true;
                            break; 
                        }

                    if (!hasPlayableTile) return false;
                    hasPlayableTile = false;
                }
            }

            for (int col = 0; col < size; col++)
            {
                if (!colsUnplayable[col])
                {
                    for (int row = 0; row < size; row++)
                        if (!this[row, col])
                        {
                            hasPlayableTile = true;
                            break;
                        }

                    if (!hasPlayableTile) return false;
                    hasPlayableTile = false;
                }
            }

            return true;
        }

        private bool IsPlayablePosition(int row, int col)
        {
            return !this[row, col];
        }

        private void OccupyPosition(int row, int col)
        {
            queensPlaced++;
            this.queensPositions[row, col] = true;
            MarkPositionsAsUnplayable(row, col);
            this.rowsUnplayable[row] = true;
            this.colsUnplayable[col] = true;
        }

        private void MarkPositionsAsUnplayable(int row, int col)
        {
            for (int i = 0; i < size; i++)
            {
                if (!this[row, i]) this[row, i] = true;
                if (!this[i, col]) this[i, col] = true;
            }

            // first diagonal
            for (int i = row, j = col; (i < size && j >= 0); ++i, --j)
                if (!this[i, j]) this[i, j] = true;

            for (int i = row, j = col; (i >= 0 && j < size); --i, ++j)
                if (!this[i, j]) this[i, j] = true;

            // second diagonal
            for (int i = row, j = col; (i < size && j < size); ++i, ++j)
                if (!this[i, j]) this[i, j] = true;

            for (int i = row, j = col; (i >= 0 && j >= 0); --i, --j)
                if (!this[i, j]) this[i, j] = true;
        }

        public QueensTurnOutput GetOutputFromTurn(int row, int col)
        {
            QueensTurnOutput result = QueensTurnOutput.Valid;

            if (this.IsPlayablePosition(row, col))
            {
                this.OccupyPosition(row, col);

                if (this.IsCompleted)
                    return QueensTurnOutput.GameCompleted;

                if (!this.HasOptionsLeft())
                    result = QueensTurnOutput.Lost;
            }
            else
            {
                if (this.queensPositions[row, col])
                    result = QueensTurnOutput.Invalid;
                else
                    result = QueensTurnOutput.Lost;
            }

            return result;
        }
    }
}
