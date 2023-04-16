using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    public class Program
    {

        public static void Main(string[] args)
        {
            //Implement your code here
            Console.WriteLine("Enter a Number");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Square of " + num + " is " + FindSquare(num));
            Console.WriteLine("Cube of " + num + " is " + FindCube(num));
        }
        //Implement methods here. Keep the method 'public' and 'static'
        public static double FindSquare(double num)
        {
            // logic
            return num * num;
        }
        public static double FindCube(double num)
        {
            // logic
            return num * num * num;
        }
    }  
}
