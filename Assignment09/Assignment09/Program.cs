using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter basic salary: ");
            double basicSalary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Total Sales Amount: ");
            double totalSalesAmount = Convert.ToDouble(Console.ReadLine());

            int commissionRate = 0;

            if (totalSalesAmount >= 5000 && totalSalesAmount <= 7500) { commissionRate = 3;
            }
            else if (totalSalesAmount >= 7501 && totalSalesAmount <= 10500)
            {
                
                commissionRate = 8;
            }
            else if(totalSalesAmount >= 10501 && totalSalesAmount <= 15000)
            {
                commissionRate = 11;
            }
            else if (totalSalesAmount >= 15000)
            {
                commissionRate = 15;
            }
            double commission = (commissionRate / 100.0) * totalSalesAmount;
            double netSalary = basicSalary + commission;

            Console.WriteLine($"Commission:{commission}");
            Console.WriteLine($"Net Salary:{netSalary}");
            Console.ReadKey();

        }
    }
}
