using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_4
{
    class Program
    {
        // 1) declare enum ComputerType
        enum ComputerType { Desktop, Laptop, Server };
        // if another type, enum declaret --- enum ComputerType : byte { Desktop, Laptop, Server };

        // 2) declare struct Computer
        struct Computer
        {
            public int cpu;
            public int memory;
            public int hdd;
            public ComputerType comptype;
        }

        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)
            int[][] departments = new int[4][];

           ////// Create a new array in the jagged array, and assign it.
            departments[0] = new int[4];
            departments[0][0] = 1;
            departments[0][1] = 2;
            departments[1][0] = 3;
            departments[1][1] = 4;

            // 4) set the size of every array in jagged array (number of computers)
            departments[1] = new int[3] { 2, 2, 1 };
            departments[2] = new int[] { 3 };
            departments[3] = new int[2] { 3, 2 };
            departments[4] = new int[3] { 1, 1, 2 };


            // 5) initialize array
            // Note: use loops and if-else statements


            // 6) count total number of every type of computers
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)



            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements


            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions


            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements

        }

    }
}
