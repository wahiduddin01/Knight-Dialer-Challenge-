using System;
using System.Collections.Generic;

namespace Chess
{
    public class ChessPiece
    {
        public Dictionary<int, List<int>> dialerLegalMoves;
        public string name;

        public ChessPiece()
        {

        }
        //constrains 1 and 2 are the numbers which the phone numbers cannot begin with (0 and 1)
        public void Calculate(int phoneNumberLength, int constraint1, int constraint2)
        {
            //row is number of steps taken and columns are numbers on the dial
            long[,] dpTable = new long[(phoneNumberLength + 1), dialerLegalMoves.Count];

            //row 1 should have all 1's for each columns as the chess piece can go to only 10 different numbers by making 1 step
            for (int i = 0; i < dialerLegalMoves.Count; i++)
            {
                dpTable[1, i] = 1;
            }

            //fill the table from top to bottom, left to right when we take more than 2 steps
            for (int row = 2; row <= phoneNumberLength; row++)
            {
                foreach (var dialNumber in dialerLegalMoves)
                {
                    foreach (var legalMove in dialNumber.Value)
                    {
                        dpTable[row, dialNumber.Key] += dpTable[row - 1, legalMove];

                        if (((legalMove == constraint1) || (legalMove == constraint2)) && ((row - 1) == 1))
                        {
                            dpTable[row, dialNumber.Key] -= dpTable[row - 1, legalMove];
                        }
                    }
                }
            }

            long validPhoneNumbers = 0;
            foreach (var dialNumber in dialerLegalMoves)
            {
                validPhoneNumbers += dpTable[phoneNumberLength, dialNumber.Key];
            }
            Console.WriteLine(("Answer for " + name + ": ") + validPhoneNumbers);
        }
    }
}
