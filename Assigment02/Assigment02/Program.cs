using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assigment02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter First Number:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second Number:");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter third Number:");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter fourth Number");
                int d = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Fifth number");
                int e = int.Parse(Console.ReadLine());

                int sum = (a + b + c + d + e);
                int average = sum / 5;
                Console.WriteLine($"Average:{average}");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                throw;
            }
        }
    }
}
