using System;

namespace Arithmetic1
{
    public class Math
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sub(int num1, int num2)
        {
            return (num1 - num2);
        }


        public int Div(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Mult(int num1, int num2)
        {
            return num1 * num2;
        }
    }


    class Program
    {
        static void Main(String[] args)
        {
            Math math = new Math();

            int num1;
            int num2;

            Console.Write("Enter Num1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Num2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Add: " + math.Add(num1, num2));
            Console.WriteLine("Subtraction: " + math.Sub(num1, num2));
            Console.WriteLine("Division: " + math.Div(num1, num2));
            Console.WriteLine("Multiplication: " + math.Mult(num1, num2));

        }
    }
}
