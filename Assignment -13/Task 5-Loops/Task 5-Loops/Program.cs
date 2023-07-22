using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using a for loop
            Console.WriteLine("Numbers from 1 to 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            //  while loop
            //Console.WriteLine("\nUsing a while loop:");
            //int num = 1;
            //while (num <= 10)
            //{
            //    Console.WriteLine(num);
            //    num++;
            //}
            // Console.ReadKey();
        }
    }
}
