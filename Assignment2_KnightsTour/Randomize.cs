using System;
using System.Collections.Generic;

namespace Assignment2_KnightsTour
{
    class Randomize:Board
    {
        public override KeyValuePair<int, int> GetNextMove(int inputrow, int inputcolumn)
        {
            Random random = new Random();
            var moves = ValidMoves(inputrow, inputcolumn);
            if (moves.Count == 0)
                throw new Exception("No valid moves left!");

            int numOfValidMoves = moves.Count;
            return moves[random.Next(numOfValidMoves)];
        }

    }
}
