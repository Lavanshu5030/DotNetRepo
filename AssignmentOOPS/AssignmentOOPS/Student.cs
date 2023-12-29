using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOPS
{
    internal class Student
    {
        // member of class
        private int m_StudentId;

        //Constructor
        public Student() {
            m_StudentId = 0;
        }

        // Overloading
        public int StudentOverloading( int a)
        {
            return a;
        }
        public int StudentOverloading(int a, int b)
        {
            return b;
        }

        // Overriding method
        public virtual int Method(int x)
        {
            Console.WriteLine("Student Class method");
            return x;
        }

        public int StudentId
        {
            // inbuilt getter and setter methods
            get { return m_StudentId; }
            set { 
                if (value <= 0) { 
                    throw new Exception("Student Id can not be zero or negative value!"); 
                }
                else
                {
                    m_StudentId = value;
                }
            }
        }
        public void display()
        {
            Console.WriteLine(m_StudentId);
        }
    }
}
