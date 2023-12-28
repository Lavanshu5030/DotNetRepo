using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) 
            {
                Console.WriteLine($"{year}:It is a leap year");
            }
            else
            {
                Console.WriteLine($"{year}:Not a leap year");
            }
        }
    }
}
