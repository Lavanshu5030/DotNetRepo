using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOPS
{
    internal class Name:Student
    {
        // Constructor
        public Name() { }   

        //Overriding Method
        public override int Method(int x)
        {
            Console.WriteLine("Name Class Method");
            return x;
        }
    }
}
