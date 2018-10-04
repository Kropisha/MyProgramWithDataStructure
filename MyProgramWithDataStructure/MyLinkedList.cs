namespace MyProgramWithDataStructure
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class MyLinkedList<T> : IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        int count;

        public int Count { get { return this.count; } }
        public bool IsEmpty { get { return this.count == 0; } }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null) this.head = node;
            else this.tail.Next = node;
            this.tail = node;
            this.count++;
        }

        public bool Remove(T data)
        {
            Node<T> current = this.head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null) this.tail = previous;
                    }
                    else
                    {
                        this.head = this.head.Next;

                        if (this.head == null) this.tail = null;
                    }
                    this.count--;
                    return true;
                }
                previous = current;
                current = current.Next;
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
            Node<T> current = this.head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                    current = current.Next;
            }
            return false;
        }

        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = this.head;
            this.head = node;
            if (this.count == 0)
                this.tail = this.head;
            this.count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = this.head;
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
    }
}
