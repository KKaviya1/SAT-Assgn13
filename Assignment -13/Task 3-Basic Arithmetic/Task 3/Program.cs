using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first integer number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine($"Addition: {sum}");

            int difference = num1 - num2;
            Console.WriteLine($"Subtraction: {difference}");

            int product = num1 * num2;
            Console.WriteLine($"Multiplication: {product}");

            if (num2 != 0)
            {
                double quotient = (double)num1 / num2;
                Console.WriteLine($"Division: {quotient}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }

            
            if (num2 != 0)
            {
                int remainder = num1 % num2;
                Console.WriteLine($"Modulus: {remainder}");
            }
            else
            {
                Console.WriteLine("Modulus by zero is not allowed.");
            }
            Console.ReadKey();
        }
    }
}
