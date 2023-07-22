using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else
            {
                long factorial = CalculateFactorial(number);
                Console.WriteLine($"Factorial of {number} is: {factorial}");
            }
            Console.ReadKey();
        }

        static long CalculateFactorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                return num * CalculateFactorial(num - 1);
            }
           
        }
        
    }
}
