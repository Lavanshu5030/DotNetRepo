using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Basic Salary: ");
            double basicSalary = Convert.ToDouble(Console.ReadLine());

            double hra = 0.20 * basicSalary;
            double da = 0.40 * basicSalary;
            double grossSalary = basicSalary + hra + da;
            double pf = 0.10 * grossSalary;
            double netSalary = grossSalary - pf;

            Console.WriteLine($"Basic Salary:{basicSalary}");
            Console.WriteLine($"HRA:{hra}");
            Console.WriteLine($"DA:{da}");
            Console.WriteLine($"GrossSalary:{grossSalary}");
            Console.WriteLine($"PF:{pf}");
            Console.WriteLine($"NetSalary:{netSalary}");
            Console.ReadKey();
        }
    }
}
