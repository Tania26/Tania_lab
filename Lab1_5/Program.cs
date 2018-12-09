using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            try
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(@"Please,  type the number:
                    1.  f(a,b) = |a-b| (unary)
                    2.  f(a) = a (binary)
                    3.  music
                    4.  morse sos
          
                    ");
                    try
                    {
                        a = (int)uint.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                My_strings();
                                Console.WriteLine("");
                                break;
                            case 2:
                                My_Binary();
                                Console.WriteLine("");
                                break;
                            case 3:
                                My_music();
                                Console.WriteLine("");
                                break;
                            case 4:
                                Morse_code();
                                Console.WriteLine("");
                                break;
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error" + e.Message);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #region ToFromBinary
        static void My_Binary()
        {
            //Implement positive integer variable input
            int hldr;
            int a;
            Console.WriteLine("Enter positive variable: ");
            a = int.Parse(Console.ReadLine());
            //Present it like binary string
            var a_str = "";
            //   For example, 4 as 100

            //Use modulus operator to obtain the remainder  (n % 2) 
            //and divide variable by 2 in the loop

            while (a > 0)
            {
                hldr = a % 2;
                a_str += hldr;
                a = a / 2;
            }

            //Use the ToCharArray() method to transform string to chararray
            //and Array.Reverse() method
            char[] arr;

            arr = a_str.ToCharArray();
            Array.Reverse(arr);

            Console.WriteLine(arr);
            Console.ReadLine();
        }
        #endregion

        #region ToFromUnary
        static void My_strings()
        {

            //Declare int and string variables for decimal and binary presentations
            int intvariable;
            string stringvariable1 = "";
            string stringvariable2 = "";


            //Implement two positive integer variables input
            int a,b;
            Console.WriteLine("Enter first positive variable: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second positive variable: ");
            b = int.Parse(Console.ReadLine());

                //To present each of them in the form of unary string use for loop
                for (int i = 0; i < a; i++)
                {
                    stringvariable1 += "1";
                }
                for (int i = 0; i < b; i++)
                {
                    stringvariable2 += "1";
                }

            //Use concatenation of these two strings
            //Note it is necessary to use some symbol ( for example “#”) to separate
            String newString = String.Join("#", stringvariable1, stringvariable2);
            Console.WriteLine(newString);


            char[] array = newString.ToCharArray();
            string res_val = "";

            foreach (char variable in array)
            {
                //Check the numbers on the equality 0
                if (!stringvariable1.Length.Equals(0) && !stringvariable2.Length.Equals(0))
                {
                    //Realize the  algorithm for replacing '1#1' to '#' by using the for loop 

                    stringvariable1 = stringvariable1.Remove(0, 1);
                    int index = stringvariable2.Length - 1;
                    stringvariable2 = stringvariable2.Remove(index);

                    String newString2 = String.Join("#", stringvariable1, stringvariable2);
                    Console.WriteLine(newString2);

                    //Delete the '#' from algorithm result
                    if (String.Equals(stringvariable1, stringvariable2) == false)
                    {
                        int loc = newString2.IndexOf('#');
                        newString2 = newString2.Remove(loc, 1);
                    }
                    else
                    {
                        newString2 = "0";
                    }
                    res_val = newString2;
                }

            }
            //Output the result 
            Console.WriteLine(res_val);
            Console.WriteLine("Result:" + res_val);
        }
        #endregion

        #region My_music
        static void My_music()
        {
            //HappyBirthday
            Thread.Sleep(1000);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(2642, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
        }
        #endregion

        #region Morse
        static void Morse_code()
        {

            //Create string variable for 'sos'     
            Console.WriteLine("Enter yor few symbol ");
            string input = Console.ReadLine();

            //Use string array for Morse code
            string[,] Dictionary_arr = new string[,] { { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" },
            { ".-   ", "-... ", "-.-. ", "-..  ", ".    ", "..-. ", "--.  ", ".... ", "..   ", ".--- ", "-.-  ", ".-.. ", "--   ", "-.   ", "---  ", ".--. ", "--.- ", ".-.  ", "...  ", "-    ", "..-  ", "...- ", ".--  ", "-..- ", "-.-- ", "--.. ", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----." }};
            //Use ToCharArray() method for string to copy charecters to Unicode character array

            char[] array = input.ToCharArray();

            //Use foreach loop for character array in which
            foreach (char value in array)
            {
                for (int j = 0; j < Dictionary_arr.GetLength(1); j++)
                {
                    
                    if (Dictionary_arr[0,j] == value.ToString())
                    {
                        Console.WriteLine(Dictionary_arr[0,j] + "  -->  " + Dictionary_arr[1, j]);
                       // char[] array2 = Dictionary_arr[1, j].ToCharArray();

                            foreach (char value2 in Dictionary_arr[1, j].ToCharArray())
                            {
                                Console.WriteLine(value2);

                            if (value2 == '.')
                            {
                                Console.Beep(1000, 250); //for '.'    
                                //Thread.Sleep(50);
                            }
                            else if (value2 == '-')
                            {
                                Console.Beep(1000, 750); // for '-'  
                            }
                            else
                            {
                                Thread.Sleep(50);
                            }
                            }
                        
                        break;
                    }
                    
                    //Use Thread.Sleep(50) to separate sounds
                }
            }

            //Implement Console.Beep(1000, 250) for '.'
            // and Console.Beep(1000, 750) for '-'
           // Thread.Sleep(2000);

        }

        #endregion
        
    }
    
}
