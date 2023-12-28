using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd number:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 4th number:");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 5th number");
            int e = int.Parse(Console.ReadLine());

            int sum = a + b + c + d + e;

            Console.WriteLine($"Sum:{sum}");
            Console.ReadKey();
        }
    }
}
