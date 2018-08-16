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
            const int MyMax = 200; //200

            Random random = new Random();
            // random.Next(MaxValue) returns a 32-bit signed integer that is greater than or equal to 0 and less than MaxValue

            
            int Guess_number = random.Next(MyMax) + 1;
            // implement input of number and comparison result message in the while circle with  comparison condition

            Console.Write("Enter the Max value: ");
            int value = int.Parse(Console.ReadLine());
            //// здесь не знаю как присвоить своё максимальное число

            int trying;
            int value_gues;
            int i = 1;

            Console.Write("Enter count your trying: ");
            trying = int.Parse(Console.ReadLine());

            while (trying > value) 
                { 

                    Console.WriteLine("Too many trying!!! Please choose value < {0}", value);
                    Console.Write("Enter count your trying: ");
                    trying = int.Parse(Console.ReadLine()); //count try guess number 
                   
               }

            while (i <= trying)
            {
                //Console.Write("Enter your guess: ");
                Console.Write("Your guess number {0}: ", trying);
                value_gues = Convert.ToInt32(Console.ReadLine());
                if (value_gues == Guess_number)
                {
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} - is right! Congratulations!", value_gues);
                    Console.ResetColor();
                    break;

                }
                if (value_gues < Guess_number)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("{0} - Too low!", value_gues);
                    Console.ResetColor();
                }
                if (value_gues > Guess_number)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} - Too high!", value_gues);
                    Console.ResetColor();
                }
                trying--;
            
            if (trying == 0)
            {
                Console.WriteLine("You have not guessed, there are no more trying!");

            }
            }
            Console.ReadLine();
        }
    }
}
