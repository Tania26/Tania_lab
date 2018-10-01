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
            public double hgz;
            public int hdd;
            public ComputerType comptype;
        }

        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)
            //Так як ми ж хочемо щоб в нас були зубчасті масиви комп'ютерів, 
            //а не просто чисел типу int (departments[1] = new int[3] { 2, 2, 1 };)
            //тому для цього в нас вище і створена структура (користувацький тип)  Computer, тому створюємо масив саме цього типу:
            Computer[,][] computers = new Computer[4, 3][]; //Виділяємо пам'ять для зубчастого масиву якиє має тип Computer

            // 4) set the size of every array in jagged array (number of computers)

            computers[0, 0] = new Computer[2];
            computers[0, 1] = new Computer[2];
            computers[0, 2] = new Computer[1];
            computers[1, 0] = new Computer[0];
            computers[1, 1] = new Computer[3];
            computers[1, 2] = new Computer[0];
            computers[2, 0] = new Computer[3];
            computers[2, 1] = new Computer[2];
            computers[2, 2] = new Computer[0];
            computers[3, 0] = new Computer[1];
            computers[3, 1] = new Computer[1];
            computers[3, 2] = new Computer[2];


            // 5) initialize array
            // Note: use loops and if-else statements

            //Ось так можна ініціалізувати елементи зубчатого масиву, але треба передбачити різні параметри комп'ютерів
            //в залежності від типу ComputerType (описаний вище), та продумати кількість циклів для запису всіх значень.

            //computers[i, j][k].CPU_cores = (byte)(4 + 2 * k);
            //computers[i, j][k].CPU_frequency = 2.5f;
            //computers[i, j][k].memory = 6;
            //computers[i, j][k].HDD = 500;


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
