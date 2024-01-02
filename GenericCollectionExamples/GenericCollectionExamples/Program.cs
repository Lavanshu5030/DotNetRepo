using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic Collections
            Console.WriteLine("---List collection");
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            // Traversing
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            // Stacks
            Console.WriteLine("---Stack collection");
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);  
            stack.Push(30);
            stack.Push(40);
            // Removing the element
            stack.Pop();

            // Traversing
            foreach(int x in stack)
            {
                Console.WriteLine(x);
            }

            // Queue
            Console.WriteLine("---Queue");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            // Removing an element
            queue.Dequeue();

            // Traversing
            foreach(int y in queue)
            {
                Console.WriteLine(y);
            }


        }
    }
}
