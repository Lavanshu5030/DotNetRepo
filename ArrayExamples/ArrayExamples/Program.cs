using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1st Example
            int[] number1 = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(number1[0]);

            // For traversing the whole array
            Console.WriteLine("--1-D Array");
            for (int i = 0; i < number1.Length; i++)
            {
                Console.WriteLine(number1[i]);
            }

            // 2-D array syntax
            int[,] number2 = new int[2, 2] { { 9, 3 }, { 7, 4 } };

            // Traversing 2-D array
            Console.WriteLine("--2-D Array:");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine(number2[row,col]);
                }
            }

            // Jagged Array or Multidimentional Array
            int[][] studentMarks = new int[3][]; //row is constant col is variable
            studentMarks[0] = new int[3]{ 10,20,30};
            studentMarks[1] = new int[5] { 56, 78, 89, 98, 76 };
            studentMarks[2] = new int[5] { 64, 45, 75, 09, 87 };

            // Traversing on jagged array
            Console.WriteLine("---Jagged Array:");
            for (int index = 0; index < 3; index++)
            {
                for (int subjects = 0; subjects< studentMarks[index].Length; subjects++)
                {
                    Console.WriteLine($"Subject id:{studentMarks[index][subjects]}\t");
                }
            }



        }
    }
}
