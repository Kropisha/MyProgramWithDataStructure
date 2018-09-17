using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgramWithDataStructure
{
    class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }

        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
    class MyQueue<T>
    {
        Node<T> head; //first value
        Node<T> tail; //last value
        int count;

        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = tail;
            tail = node;

            if (count == 0)
            {
                head = tail;
            }
            else tempNode.Next = tail;
            count++;
        }

        public T Dequeue()
        {
            if (count == 0)
            {
                Console.WriteLine("The queue is empty.");
            }
            T output = head.Data;
            head = head.Next;
            count--;
            return output;
        }

        public T First
        {
            get
            {
                if(isEmpty) Console.WriteLine("The queue is empty.");
                return head.Data;
            }
        }

        public T Last
        {
            get
            {
                if (isEmpty) Console.WriteLine("The queue is empty.");
                return tail.Data;
            }
        }

        public int Count { get { return count; } }
        public bool isEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T Data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(Data))
                    return true;
                current = current.Next;
            } return false;
            }
        }
    }

