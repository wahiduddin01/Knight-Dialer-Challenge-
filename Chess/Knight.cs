using System;
using System.Collections.Generic;

namespace Chess
{
    public class Knight : ChessPiece
    {

        public Dictionary<int, List<int>> dialerLegalMoves;
        public string name = "Knight";

        public Knight()
        {
            //All the possible paths for each number on the dial
            dialerLegalMoves = new Dictionary<int, List<int>>
            {
                [0] = new List<int> { 4, 6 },
                [1] = new List<int> { 6, 8 },
                [2] = new List<int> { 7, 9 },
                [3] = new List<int> { 4, 8 },
                [4] = new List<int> { 3, 9, 0 },
                [5] = new List<int>(),
                [6] = new List<int> { 1, 7, 0 },
                [7] = new List<int> { 2, 6 },
                [8] = new List<int> { 1, 3 },
                [9] = new List<int> { 2, 4 }
            };

            base.dialerLegalMoves = dialerLegalMoves;
            base.name = name;
            
        }
    }
}
