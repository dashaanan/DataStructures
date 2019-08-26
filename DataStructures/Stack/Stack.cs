using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Stack : IStack
    {

        private int iintTop;
        public bool isEmpty()
        {
            return null == ilstStack || ilstStack.Count == 0;
        }

        public void Peek()
        {
            if (!isEmpty())
            {
                Console.WriteLine($"Element at the top of stack is: {ilstStack[iintTop - 1]}");
            }
            else
            {
                Console.WriteLine($"Stack is Empty");
            }
        }

        public void Pop()
        {
            if (!isEmpty())
            {
                iintTop--;
                Console.WriteLine($"Popping : {ilstStack[iintTop]} from top of stack");
                ilstStack.RemoveAt(iintTop);
                
            }
            else
            {
                Console.WriteLine($"Stack is Empty");
            }
        }


        public void Push<T>(T iintStackTop)
        {

            if (null == ilstStack)
            {
                ilstStack = new List<int>();
            }
            ilstStack.Add(Convert.ToInt32(iintStackTop));
            iintTop = ilstStack.Count;
            Console.WriteLine($"Added {iintStackTop} at Top of stack at imdex:{iintTop - 1}");
        }

        List<int> ilstStack { get; set; }
    }
}
