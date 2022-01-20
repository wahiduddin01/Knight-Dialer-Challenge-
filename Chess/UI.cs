using System;
namespace Chess
{
    public class UI
    {

        public int phoneNumLength;
        public int constraint1;
        public int constraint2;

        public UI()
        {
            //
        }

        public void Run()
        {
            Console.WriteLine("Enter the desired length of a valid phone number (min 1 and max 10)");

            string phoneNumLengthtStr = Console.ReadLine();
            phoneNumLengthtStr = phoneNumLengthtStr.Trim();
            Boolean isNumeric = int.TryParse(phoneNumLengthtStr, out phoneNumLength);

            if (isNumeric == false)
            {
                Console.WriteLine("Invalid entry");
                Run();
            }
            else
            {
                if ((phoneNumLength >= 1) && (phoneNumLength <= 10))
                {
                    getConstraint1();
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                    Run();
                }
            }
        }

        public void getConstraint1()
        {
            Console.WriteLine("Enter a number from 0-9 to exclude phone numbers starting with that number (enter 'none' if no numbers should be excluded)");

            string constraint1Str = Console.ReadLine();
            constraint1Str = constraint1Str.Trim();
            Boolean isNumeric = int.TryParse(constraint1Str, out constraint1);

            if (isNumeric == false)
            {
                if (constraint1Str.Equals("none"))
                {
                    constraint1 = 100;
                    constraint2 = 100;
                    ProceedCalculation();
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                    getConstraint1();
                }
            }
            else
            {
                if ((constraint1 >= 0) && (constraint1 <= 9))
                {
                    getConstraint2();
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                    getConstraint1();
                }
            }
        }

        public void getConstraint2()
        {
            Console.WriteLine("Enter another number from 0-9 to exclude another group of phone numbers starting with that number (enter 'none' if another constraint is not needed)");

            string constraint2Str = Console.ReadLine();
            constraint2Str = constraint2Str.Trim();
            Boolean isNumeric = int.TryParse(constraint2Str, out constraint2);

            if (isNumeric == false)
            {
                if (constraint2Str.Equals("none"))
                {
                    constraint2 = 100;
                    ProceedCalculation();
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                    getConstraint2();
                }
            }
            else
            {
                if ((constraint2 >= 0) && (constraint2 <= 9))
                {
                    ProceedCalculation();
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                    getConstraint2();
                }
            }
        }

        public void ProceedCalculation()
        {
            Pawn pawn = new Pawn();
            Knight knight = new Knight();
            Rook rook = new Rook();
            Bishop bishop = new Bishop();
            Queen queen = new Queen();
            King king = new King();

            pawn.Calculate(phoneNumLength,constraint1,constraint2);
            knight.Calculate(phoneNumLength, constraint1, constraint2);
            bishop.Calculate(phoneNumLength, constraint1, constraint2);
            rook.Calculate(phoneNumLength, constraint1, constraint2);
            king.Calculate(phoneNumLength, constraint1, constraint2);
            queen.Calculate(phoneNumLength, constraint1, constraint2);
        }
    }
}
