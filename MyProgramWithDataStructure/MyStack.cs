using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgramWithDataStructure
{
    class MyStack<T>
    {
        T[] stck; //array with stack
        int tos; // index of top value
        int size=10;

        public MyStack()
        {
            stck = new T[size]; //memory for stack
            tos = 0;
        }

        public MyStack(int length)
        {
            stck = new T[length]; //memory for stack
            tos = 0;
        }

        public void Push(T ch)
        {
            if (tos == stck.Length)
            {
                Console.WriteLine("The stack is full.");
                return;
            }
            stck[tos] = ch;
            tos++;
        }

        public T Pop()
        {
            if (tos == 0)
            {
                Console.WriteLine("The stack is empty.");
            }
            tos--;
            return stck[tos];
        }

        public bool isFull()
        {
            return tos == stck.Length;
        }

        public bool isEmpty()
        {
            return tos == 0;
        }

        public int Capacity()
        {
            return stck.Length;
        }
    }
}
