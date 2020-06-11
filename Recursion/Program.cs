using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter your number: ");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorialRecursion(n));
        }
        static int factorialRecursion(int number)
        {
            if(number==0)
            return 1;
            else
            return (number*factorialRecursion(number-1));
        }
    }
}
