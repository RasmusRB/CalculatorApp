using System;
using CalculatorDLL;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition");
            Console.WriteLine("========");
            Console.WriteLine("Enter number a : ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter number b : ");
            int b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("The result is: " + Calculator.Addition(a, b));

            //Console.WriteLine(Calculator.Addition(4,5));
            //Console.WriteLine(Calculator.Divide(20, 5));
            //Console.WriteLine(Calculator.Multiplication(5, 20));
            //Console.WriteLine(Calculator.Subtraction(10, 5));

            //Console.WriteLine(Calculator.Addition(5.5, 6.7));
            //Console.WriteLine(Calculator.Divide(100.0, 6.0));
            //Console.WriteLine(Calculator.Multiplication(15.5, 14.2));
            //Console.WriteLine(Calculator.Subtraction(25.0, 10.0));

            Console.ReadKey();
        }
    }
}
