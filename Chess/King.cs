using System;
using System.Collections.Generic;

namespace Chess
{
    public class King : ChessPiece
    {

        public Dictionary<int, List<int>> dialerLegalMoves;
        public string name = "King";

        public King()
        {
            //All the possible paths for each number on the dial
            dialerLegalMoves = new Dictionary<int, List<int>>
            {
                [0] = new List<int> { 7, 8, 9 },
                [1] = new List<int> { 2, 4, 5 },
                [2] = new List<int> { 1, 3, 4, 5, 6 },
                [3] = new List<int> { 2, 5, 6 },
                [4] = new List<int> { 1, 2, 5, 7, 8 },
                [5] = new List<int> { 1, 2, 3, 4, 6, 7, 8, 9 },
                [6] = new List<int> { 2, 3, 5, 8, 9 },
                [7] = new List<int> { 0, 4, 5, 8 },
                [8] = new List<int> { 0, 4, 5, 6, 7, 9 },
                [9] = new List<int> { 0, 5, 6, 8 }
            };

            base.dialerLegalMoves = dialerLegalMoves;
            base.name = name;
        }
    }
}
