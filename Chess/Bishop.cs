using System;
using System.Collections.Generic;

namespace Chess
{
    public class Bishop : ChessPiece
    {

        public Dictionary<int, List<int>> dialerLegalMoves;
        public string name = "Bishop";

        public Bishop()
        {
            //All the possible paths for each number on the dial
            dialerLegalMoves = new Dictionary<int, List<int>>
            {
                [0] = new List<int> { 7, 9 },
                [1] = new List<int> { 5, 9 },
                [2] = new List<int> { 4, 6 },
                [3] = new List<int> { 5, 7 },
                [4] = new List<int> { 2, 8 },
                [5] = new List<int> { 1, 3, 7, 9 },
                [6] = new List<int> { 2, 8 },
                [7] = new List<int> { 0, 3, 5 },
                [8] = new List<int> { 4, 6},
                [9] = new List<int> { 0, 1, 5 }
            };

            base.dialerLegalMoves = dialerLegalMoves;
            base.name = name;
        }
    }
}
