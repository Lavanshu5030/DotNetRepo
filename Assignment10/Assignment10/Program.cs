using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            int b = int.Parse(Console.ReadLine());
            int choice;
            do {
                Console.WriteLine("---Menu---");
                Console.WriteLine("Enter 1 to add two number");
                Console.WriteLine("Enter 2 to subtract two number");
                Console.WriteLine("Enter 3 to multiply two number");
                Console.WriteLine("Enter 4 to divide two number");
                Console.WriteLine("Enter 5 to exit menu");
                Console.WriteLine("Enter you choice:");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(a + b);
                        break;

                    case 2:
                        Console.WriteLine(a - b);
                        break;

                    case 3:
                        Console.WriteLine(a * b);
                        break;
                        
                    case 4:
                        Console.WriteLine(a / b);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }while (choice != 5);

          //  Console.ReadKey();  
        }
    }
}
