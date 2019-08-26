using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            for (int i = 0; i < 50; i++)
            {
                s.Push(i*2);
            }
            for (int i = 0; i < 50; i++)
            {
                
                s.Pop();
                s.Peek();
                Console.WriteLine("-----------------------------------");
            }

            
            Console.ReadKey();
        }
    }
}
