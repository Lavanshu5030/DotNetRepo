using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Infoway Interview Application");
            try
            {
                Student student = new Student();
                Student name = new Name();// used for overriding
                // initialising and calling method at same time
                student.StudentId = 1;
                Console.WriteLine(student.StudentOverloading(10,20));
                Console.WriteLine($"Overriden:{ name.Method(23)}");
                //student.display();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }

        }
    }
}
