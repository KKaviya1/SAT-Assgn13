using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 6, 9, 12, 15 };

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine($"The sum of the elements in the array is: {sum}");
            Console.WriteLine($"The average of the elements in the array is: {average}");
            Console.ReadKey();
        }
    }
}

