using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public interface IStack
    {
        void Push<T>(T item);
        void Pop();
        void Peek();
        bool isEmpty();
    }
}
