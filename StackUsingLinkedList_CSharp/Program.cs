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
            public void pop()
            {
                Console.WriteLine("\nThe popped element is: " + top.info);
                top = top.next;//Make top point to the next node is sequence
            }
            public void display()
            {
                node tmp;
                if (empty()) //If Stack is empty
                    Console.WriteLine("\nStack Empty");

            }
        }
        static void Main(string[] args)
        {
        }
    }
}
