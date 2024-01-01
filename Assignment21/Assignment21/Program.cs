using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            do { 
                Console.WriteLine("---Menu---");
                Console.WriteLine("Enter 1 to get Square area");
                Console.WriteLine("Enter 2 to get Rectangle area");
                Console.WriteLine("Enter 3 to get Circle area");
                Console.WriteLine("Enter 4 to exit area");
                Console.WriteLine("Enter your choice:");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Area area1 = new Area(5);
                        Console.WriteLine(area1.AreaOfSquare());
                        break;

                    case 2:
                        Area area2 = new Area(2, 3);
                        Console.WriteLine(area2.AreaOfRectangle()); 
                        break;

                    case 3:
                        Area area3 = new Area(3.0);
                        Console.WriteLine(area3.AreaOfCircle());
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            while (choice != 4);

        }
    }
}
