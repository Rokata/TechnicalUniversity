using System;
using System.Collections.Generic;

namespace QueensGame.Models
{
    public class Queensboard
    {
        private int size;
        private bool[,] boardPositions;
        private int queensPlaced;

        public Queensboard(int size)
        {
            this.size = size;
            this.queensPlaced = 0;
            this.boardPositions = new bool[size, size];
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

        public bool IsPlayablePosition(int row, int col)
        {
            return !this[row, col];
        }

        public void OccupyPosition(int row, int col)
        {
            queensPlaced++;
            MarkPositionsAsUnplayable(row, col);
        }

        public bool HasPositionsAvailable()
        {
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    if (!this[i, j]) return true;

            return false;
        }

        private void MarkPositionsAsUnplayable(int row, int col)
        {
            for (int i = 0; i < size; i++) {             
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

            if (this.HasPositionsAvailable())
            {
                if (this.IsPlayablePosition(row, col))
                {
                    this.OccupyPosition(row, col);

                    if (this.IsCompleted)
                        result = QueensTurnOutput.Completed;
                }
                else
                    result = QueensTurnOutput.Lost;
            }

            return result;
        }
    }
}
