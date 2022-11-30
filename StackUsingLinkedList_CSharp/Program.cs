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
                else 
                    return false;
            }
            public void push(int element)
            {
                node fresh;
                fresh = new node(element, null);

                fresh.next = top;
                top = fresh;
                Console.WriteLine("\n" + element + "pushed.");
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
