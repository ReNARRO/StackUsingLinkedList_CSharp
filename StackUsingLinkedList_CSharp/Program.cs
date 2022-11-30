using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList_CSharp
{
    internal class Program
    {
        class node
        {
            public int info;
            public node next;
            public node(int i, node n)
            {
                info = i;
                next = n;
            }
        }
        class Stacks
        {
            node top;
            public Stacks()
            {
                top = null;
            }
            bool empty()
            {
                if (top == null)
                    return true;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
