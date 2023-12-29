using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            int c = int.Parse(Console.ReadLine());

            //if ( a >= b && a >= c)
            //{
            //    Console.WriteLine($"{a} is the maximum among all");
            //}
            //else if ( b >= a && b >= c) 
            //{
            //    Console.WriteLine($"{b} is the maximum among all");
            //}
            //else { Console.WriteLine($"{c} is the maximum among all"); }

            // Using conditional operator
            int max = (a >= b && a >= c) ? a : (b >= a && b >= c) ? b : c;
            Console.WriteLine($"{max}:Maximum among all");
        }
    }
}
