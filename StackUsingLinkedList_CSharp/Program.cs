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
        static void Main(string[] args)
        {
        }
    }
}
