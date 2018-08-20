using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factirial calculation
            ");

            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(" - Farmer, wolf, goat and cabbage puzzle\n");
                    Farmer_puzzle();

                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(" - Console calculator\n");
                    Calculator();

                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(" - Factirial calculation\n");
                    Factorial_calculation();

                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle()
        {
            //Key sequence: 3817283 or 3827183
            // Declare 7 int variables for the input numbers and other variables
            int wr1, wr2, wr3, wr4, wr5, wr6, wr7;
            wr1 = int.Parse(Console.ReadLine());
            wr2 = int.Parse(Console.ReadLine());
            wr3 = int.Parse(Console.ReadLine());
            wr4 = int.Parse(Console.ReadLine());
            wr5 = int.Parse(Console.ReadLine());
            wr6 = int.Parse(Console.ReadLine());
            wr7 = int.Parse(Console.ReadLine());
            string result1 = "3817283";
            string result2 = "3827183";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
At the same time can neither carry nor leave together on the banks of a wolf and a goat, 
a goat and cabbage. You can only carry a wolf with cabbage or as each passenger separately. 
You can do whatever how many flights. How to transport the wolf, goat and cabbage that all went well?");
            Console.WriteLine("There: farmer and wolf - 1");
            Console.WriteLine("There: farmer and cabbage - 2");
            Console.WriteLine("There: farmer and goat - 3");
            Console.WriteLine("There: farmer  - 4");
            Console.WriteLine("Back: farmer and wolf - 5");
            Console.WriteLine("Back: farmer and cabbage - 6");
            Console.WriteLine("Back: farmer and goat - 7");
            Console.WriteLine("Back: farmer  - 8");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please,  type numbers by step ");
            // Implement input and checking of the 7 numbers in the nested if-else blocks with the  Console.ForegroundColor changing


            //if (result1 ||result2)
            //{


            //    if (wr1 == 3)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.WriteLine("3");
            //    }
            //    else Console.ForegroundColor = ConsoleColor.Red;
            //}
        }
        #endregion

        #region calculator
        static void Calculator()
        {
            // Set Console.ForegroundColor  value
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Select the arithmetic operation:\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Multiplication");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2. Divide ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("3. Addition ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("4. Subtraction");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("5. Exponentiation ");

            // Restore the original console colors.
            Console.ResetColor();

            // Implement option input (1,2,3,4,5)

            double result;
            int i, value1, value2;
            i = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter two number: ");
            value1 = int.Parse(Console.ReadLine());
            value2 = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Multiplication");
                    result = value1 * value2;
                    Console.WriteLine("{0} * {1} = {2}", value1, value2, result);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Divide");
                    result = (double)value1 / (double)value2;
                    Console.WriteLine("{0} / {1} = {2}", value1, value2, result);
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Addition");
                    result = value1 + value2;
                    Console.WriteLine("{0} + {1} = {2}", value1, value2, result);
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Subtraction");
                    result = value1 - value2;
                    Console.WriteLine("{0} - {1} = {2}", value1, value2, result);
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Exponentiation");
                    result = Math.Pow(value1, value2);
                    Console.WriteLine("{0} sqrt {1} = {2}", value1, value2, result);
                    break;
                default:
                    Console.ResetColor();
                    Console.WriteLine("Exit");
                    break;
            }


            //     and input of  two or one numbers
            //  Perform calculations and output the result 
        }
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            // Implement input of the number

            int a;
            int factorial = 1;

            Console.Write("\n" + "Input the number" + "\n" + "!");
            a = int.Parse(Console.ReadLine());

            // Implement input the for circle to calculate factorial of the number

            for (int i = 2; i <= a; i++)
            {
                factorial = factorial * i;
            }
            // Output the result
            Console.WriteLine("factorial !{0} = {1}", a, factorial);
            Console.ReadLine();
        }
        #endregion

    }
}
