using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = 'a';
            int asciiOfCh = Convert.ToInt32(ch);
            Console.WriteLine($"Ascii Value of character 'a':{asciiOfCh}");
            Console.ReadKey();
        }
    }
}
