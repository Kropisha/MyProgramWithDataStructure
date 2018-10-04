namespace MyProgramWithDataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class MyStack<T>
    {
        T[] stck; // array with stack
        int tos; // index of top value
        int size = 10;

        public MyStack()
        {
            this.stck = new T[this.size]; // memory for stack
            this.tos = 0;
        }

        public MyStack(int length)
        {
            this.stck = new T[length]; // memory for stack
            this.tos = 0;
        }

        public void Push(T ch)
        {
            if (this.tos == this.stck.Length)
            {
                Console.WriteLine("The stack is full.");
                return;
            }
            this.stck[this.tos] = ch;
            this.tos++;
        }

        public T Pop()
        {
            if (this.tos == 0)
            {
                Console.WriteLine("The stack is empty.");
            }
            this.tos--;
            return this.stck[this.tos];
        }

        public bool IsFull()
        {
            return this.tos == this.stck.Length;
        }

        public bool IsEmpty()
        {
            return this.tos == 0;
        }

        public int Capacity()
        {
            return this.stck.Length;
        }
    }
}
