using System;
using System.Collections.Generic;

namespace Assignment2_KnightsTour
{
    class Heuristic : Randomize
    {
        private static int[,] accessabilityMatrix = { { 2, 3, 4, 4, 4, 4, 3, 2 },
                                                      { 3, 4, 6, 6, 6, 6, 4, 3 },
                                                      { 4, 6, 8, 8, 8, 8, 6, 4 },
                                                      { 4, 6, 8, 8, 8, 8, 6, 4 },
                                                      { 4, 6, 8, 8, 8, 8, 6, 4 },
                                                      { 4, 6, 8, 8, 8, 8, 6, 4 },
                                                      { 3, 4, 6, 6, 6, 6, 4, 3 },
                                                      { 2, 3, 4, 4, 4, 4, 3, 2 } };

        // Overriding the ValidMoves method from Board class.
        public override List<KeyValuePair<int, int>> ValidMoves(int inputrow, int inputcolumn)
        {
            var moves = base.ValidMoves(inputrow, inputcolumn);

            var filteredMoves = new List<KeyValuePair<int, int>>();
            var noMoves = new List<KeyValuePair<int, int>>();
            
            // for every valid move in the Randomize parent class
            foreach (var move in moves)
            {
                // neighbourNeighbours will be looking for valid moves of the 
                var neighbourNeighbours = base.ValidMoves(move.Key, move.Value);
                if (neighbourNeighbours.Count > 0)
                {
                    int power = 2;
                    int weight = (int)(1 + Math.Pow(8, power) - Math.Pow(accessabilityMatrix[move.Key, move.Value], power));
                    for (int i = 0; i < weight; i++)
                        filteredMoves.Add(move);
                }
                else
                    noMoves.Add(move);
            }
            return filteredMoves.Count != 0 ? filteredMoves : noMoves;
        }
    }
}
