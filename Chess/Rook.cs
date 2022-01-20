using System;
using System.Collections.Generic;

namespace Chess
{
    public class Rook : ChessPiece
    {

        public Dictionary<int, List<int>> dialerLegalMoves;
        public string name = "Rook";

        public Rook()
        {
            //All the possible paths for each number on the dial
            dialerLegalMoves = new Dictionary<int, List<int>>
            {
                [0] = new List<int> { 2, 5, 8 },
                [1] = new List<int> { 2, 3, 4, 7 },
                [2] = new List<int> { 0, 1, 3, 5, 8},
                [3] = new List<int> { 1, 2, 6, 9},
                [4] = new List<int> { 1, 5, 6, 7},
                [5] = new List<int> { 0, 2, 4, 6, 8},
                [6] = new List<int> { 3, 4, 5, 9},
                [7] = new List<int> { 1, 4, 8, 9},
                [8] = new List<int> { 0, 2, 5, 7, 9},
                [9] = new List<int> { 3, 6, 7, 8}
            };

            base.dialerLegalMoves = dialerLegalMoves;
            base.name = name;
        }
    }
}
