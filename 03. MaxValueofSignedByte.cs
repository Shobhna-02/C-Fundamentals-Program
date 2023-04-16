using System;
using System.Diagnostics.SymbolStore;

public class Program      //DO NOT change the class name
{
   // implement code here
    static void Main(string[] args)
    {
        sbyte number = 125;
        Console.WriteLine("Value of number: " + number);
        // number largest possible byte logic
        var max = number * SByte.MaxValue;
        Console.WriteLine("Largest value stored in a signed byte : " + max);
    }
}
