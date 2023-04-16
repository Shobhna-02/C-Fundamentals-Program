using System;

namespace ProgFundamentals4 
{
    public class Program      
    {
        //implement code here
        static void Main(string[] args)
        {
            long num1, num2;

            Console.WriteLine("Enter large number 1:");
            // Take input num1
            num1 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter large number 2:");
            // Take input num2
            num2 = Convert.ToInt64(Console.ReadLine());

            long sum = num1 + num2;

            Console.WriteLine("The result is: " + sum);
        }
    }
}