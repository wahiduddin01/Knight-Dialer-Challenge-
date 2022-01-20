using System;
using System.Collections.Generic;

namespace Chess
{
    public class Pawn : ChessPiece
    {

        public Dictionary<int, List<int>> dialerLegalMoves;
        public string name = "Pawn";

        public Pawn()
        {
            //All the possible paths for each number on the dial
            dialerLegalMoves = new Dictionary<int, List<int>>
            {
                [0] = new List<int>(),
                [1] = new List<int> { 4 },
                [2] = new List<int> { 5 },
                [3] = new List<int> { 6 },
                [4] = new List<int> { 7 },
                [5] = new List<int> { 8 },
                [6] = new List<int> { 9 },
                [7] = new List<int>(),
                [8] = new List<int>(),
                [9] = new List<int>()
            };

            base.dialerLegalMoves = dialerLegalMoves;
            base.name = name;
        }
    }
}
