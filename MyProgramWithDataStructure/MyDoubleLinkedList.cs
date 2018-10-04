namespace MyProgramWithDataStructure
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class DoubleNode<T>
    {
        public DoubleNode(T data)
        {
            this.Data = data;
        }
        public T Data { get; set; }
        public DoubleNode<T> Previous { get; set; }
        public DoubleNode<T> Next { get; set; }
    }

   public class MyDoubleLinkedList<T> : IEnumerable<T>
    {
        DoubleNode<T> head;
        DoubleNode<T> tail;
        int count;

        public int Count { get { return this.count; } }
        public bool IsEmpty { get { return this.count == 0; } }

        public void Add(T data)
        {
            DoubleNode<T> node = new DoubleNode<T>(data);
            if (this.head == null) this.head = node;
            else
            {
                this.tail.Next = node;
                node.Previous = this.tail;
            }
            this.tail = node;
            this.count++;
        }

        public void AddFirst(T data)
        {
            DoubleNode<T> node = new DoubleNode<T>(data);
            DoubleNode<T> temp = this.head;
            node.Next = temp;
            this.head = node;
            if (this.count == 0)
            {
                this.tail = this.head;
            }
            else temp.Previous = node;
            this.count++;
        }

        public bool Remove(T data)
        {
            DoubleNode<T> current = this.head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    this.tail = current.Previous;
                }
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    this.head = current.Next;
                }
                this.count--;
                return true;
            }
            return false;
        }

        public void Clear()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public bool Contains(T data)
        {
            DoubleNode<T> current = this.head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            DoubleNode<T> current = this.head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        public IEnumerable<T> BackEnumerator()
        {
            DoubleNode<T> current = this.tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
    }
}
