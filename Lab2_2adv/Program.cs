using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2adv
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MyMax = 200;

            Random random = new Random();
            // random.Next(MaxValue) returns a 32-bit signed integer that is greater than or equal to 0 and less than MaxValue
            int Guess_number = random.Next(MyMax) + 1;
            // implement input of number and comparison result message in the while circle with  comparison condition

            Console.Write("Enter the Max value: ");
            int value = int.Parse(Console.ReadLine());
            Console.Write("Enter count your trying: ");
            int trying = int.Parse(Console.ReadLine()); //count try guess number

            if (trying < value)
            {
                Console.Write("Enter count your trying: ");
                trying = int.Parse(Console.ReadLine()); //count try guess number      
            }
            else
            {
                Console.WriteLine("Too many trying!!! Please choose value < {0}", value);
            }

            do
            {
                //
            }
            while (trying > 0);
            Console.Write("Enter your guess: ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Too low!");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Too high!");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" is right! Congratulations!");
            Console.ResetColor();
        }
    }
}
