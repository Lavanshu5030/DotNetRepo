using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21
{
    internal class Area
    {
        int m_side;
        int m_length;
        int m_width;
        double m_radius;

        //Constructor
        internal Area(int side) { m_side = side; }
        internal Area(int length, int width) { m_length = length; m_width = width; }

        internal Area(double radius) {
            m_radius = radius; 
        }

        internal int AreaOfSquare()
        {
            int area = m_side * m_side;
            return area;
        }
        internal int AreaOfRectangle()
        {
            int area = m_length * m_width;
            return area;
        }

        internal double AreaOfCircle()
        {
            double area = 3.14 * m_radius * m_radius;
            return area;
        }

        
    }
}
