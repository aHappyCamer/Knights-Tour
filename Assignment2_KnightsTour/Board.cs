using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_KnightsTour
{
        abstract class Board
        {

        protected List<KeyValuePair<int, int>> previousMoves = new List<KeyValuePair<int, int>>();
        private int[,] PlayingBoard = new int[8, 8];
        private int size = 8;
        private int run;
        private int countNumOfMoves;

        // property
        public string Output { get; private set; }

        public abstract KeyValuePair<int, int> GetNextMove(int inputrow, int inputcolumn);

        public Board()
        {
            Reset();
        }

        
        public void Reset()
        {
            previousMoves.Clear();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    PlayingBoard[i, j] = 0;
                }
            }
        }

        public void AddToBoard(int row, int column)
        {
            AddToPreviousMoves(row, column);
            ValidMoves(row, column);
        }

        //prints the board with all the moves
        public void PrintBoard()
        {
            int unoccupied = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int foundIndex = previousMoves.FindIndex(x => x.Key == i && x.Value == j);
                    if (foundIndex >= 0)
                        Console.Write("{0, -3} ", foundIndex + 1);
                    else
                        Console.Write("{0, -3} ", unoccupied);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Trial: " + run);
            Console.WriteLine();
            Output += printOutput();
        }

        public virtual List<KeyValuePair<int, int>> ValidMoves(int row, int column)
        {
            int[] validRowMoves = { 2, 2, -2, -2, 1, 1, -1, -1 };
            int[] validColumnMoves = { 1, -1, 1, -1, 2, -2, 2, -2 };
            var legalMoves = new List<KeyValuePair<int, int>>();

            for (int i = 0; i < 8; i++)
            {
                int newRow = row + validRowMoves[i];
                int newCol = column + validColumnMoves[i];
                if (newCol >= 0 && newCol <= 7 &&
                    newRow >= 0 && newRow <= 7 &&
                    PlayingBoard[newRow, newCol] == 0)
                    legalMoves.Add(new KeyValuePair<int, int>(newRow, newCol));
            }
            return legalMoves;
        }

        public List<KeyValuePair<int, int>> AddToPreviousMoves(int row, int column)
        {
            if (!IsOccupied(row, column))
            {
                previousMoves.Add(new KeyValuePair<int, int>(row, column));
                PlayingBoard[row, column] = 1;
            }
            return previousMoves;
        }

        public List<int> PlayGame(int row, int column, int runs)
        {
            List<int> numMovesList = new List<int>();
            int oldRow = row;
            int oldCol = column;
            Output = null;
            for (int i = 0; i < runs; i++)
            {
                run = i + 1;
                try
                {
                    while (true)
                    {
                        AddToBoard(row, column);
                        KeyValuePair<int, int> move = GetNextMove(row, column);
                        row = move.Key;
                        column = move.Value;
                    }
                }
                catch (Exception e)
                {
                    countNumOfMoves = previousMoves.Count;
                    numMovesList.Add(previousMoves.Count);
                    PrintBoard();
                    this.Reset();
                    row = oldRow;
                    column = oldCol;
                }
            }
            return numMovesList;
        }

        public bool IsOccupied(int row, int column)
        {
            return previousMoves.Any(x => x.Key == row && x.Value == column);
        }

        public string printOutput()
        {
            return String.Format("Trial {0}: The Knight was able to successfully touch {1} squares." 
                + Environment.NewLine, run, countNumOfMoves);
        }
    }
}
