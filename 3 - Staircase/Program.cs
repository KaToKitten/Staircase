using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of size: ");
            string strSIZE = Console.ReadLine();
            int size, i, j, k;

            /* INPUT VALIDATION */
            bool check = int.TryParse(strSIZE, out size);
            bool valid = check && size > 0;
            while (!valid)
            {
                Console.WriteLine("Invalid Input, Try again...");
                Console.Write("Input number of size: ");
                strSIZE = Console.ReadLine();
                check = int.TryParse(strSIZE, out size);
                valid = check && size > 0;
            }

            /* DRAWING THE PATTERN*/
            for (i = 1; i <= size; i++) 
            {
                for (j = 1; j <= (size - i); j++) { Console.Write(" "); }
                for (k = 1; k < i * 2; k++) 
                { 
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press Any Key to Quit.");
            Console.ReadKey();
        }
    }
}
