using System;
namespace ProgFundamentals5
{
    public class Program
    {
        //implement code here

        static void Main(string[] args)
        {
            string name, city;
            Char gender;
            long mobile, pincode;
            float age;

            Console.WriteLine("Enter name");
            name = Console.ReadLine();

            Console.WriteLine("Enter age(completed years and months)");
            age = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter gender('M' for Male and 'F' for Female)");
            gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter city");
            city = Console.ReadLine();

            Console.WriteLine("Enter mobile number");
            mobile = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter pincode");
            pincode = Convert.ToInt64(Console.ReadLine());


            Console.WriteLine("Name : {0}, Age : {1}", name, age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Mobile: " + mobile);
            Console.WriteLine("Pincode: " + pincode);

        }
    }
}
    