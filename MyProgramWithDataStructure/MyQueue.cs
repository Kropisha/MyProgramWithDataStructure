namespace MyProgramWithDataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Node<T>
    {
        public Node(T data)
        {
            this.Data = data;
        }

        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
    class MyQueue<T>
    {
        Node<T> head; // first value
        Node<T> tail; // last value
        int count;

        public T First
        {
            get
            {
                if (this.IsEmpty) Console.WriteLine("The queue is empty.");
                return this.head.Data;
            }
        }

        public T Last
        {
            get
            {
                if (this.IsEmpty) Console.WriteLine("The queue is empty.");
                return this.tail.Data;
            }
        }

        public int Count { get { return this.count; } }
        public bool IsEmpty { get { return this.count == 0; } }

        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = this.tail;
            this.tail = node;

            if (this.count == 0)
            {
                this.head = this.tail;
            }
            else tempNode.Next = this.tail;
            this.count++;
        }

        public T Dequeue()
        {
            if (this.count == 0)
            {
                Console.WriteLine("The queue is empty.");
            }
            T output = this.head.Data;
            this.head = this.head.Next;
            this.count--;
            return output;
        }

        
        public void Clear()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> current = this.head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
            }
        }
    }

