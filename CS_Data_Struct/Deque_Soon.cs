using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Data_Struct
{
    class DequeNode<T>
    {
        public T data { get; set; }
        public DequeNode<T> Next { get; set; }
        public DequeNode<T> Pre { get; set; }
    }

    class Deque_Soon<T>
    {
        DequeNode<T> Head;
        
        DequeNode<T> Tail;
        int cnt = 0;

        public void EnqueueLeft(T a_data)
        {
            if (Head == null)
            {
                this.Head = new DequeNode<T>();

                this.Head.data = a_data;
                this.Head.Next = null;
                Tail = Head;
            }
            else
            {
                DequeNode<T> newNode = new DequeNode<T>();
                newNode.data = a_data;

                newNode.Next = Head;
                Head = newNode;
                
            }

            cnt++;
        }

        public void EnqueueRight(T a_data)
        {
            if (Head == null)
            {
                this.Head = new DequeNode<T>();

                this.Head.data = a_data;
                this.Head.Next = null;
                Tail = Head;
            }
            else
            {
                DequeNode<T> newNode = new DequeNode<T>();
                newNode.data = a_data;
                DequeNode<T> TempNode = Tail;

                Tail.Next = newNode;
                Tail = newNode;
                newNode.Pre = TempNode;
            }

            cnt++;
        }

        public void Print()
        {
            DequeNode<T> tempNode = Head;

            while (tempNode != null)
            {
                Console.WriteLine(tempNode.data);
                tempNode = tempNode.Next;
            }
        }

        public DequeNode<T> DequeueLeft()
        {
            if (Head == null) return null;

            DequeNode<T> DeqNode = Head;

            Head = Head.Next;

            cnt--;
            return DeqNode;
        }

        public DequeNode<T> DequeueRight()
        {
            if (Head == null) return null;

            DequeNode<T> DeqNode = Tail;
            Tail = Tail.Pre;
            Tail.Next = null;

            cnt--;
            return DeqNode;
        }

        public DequeNode<T> Peek()
        {
            if (Head != null) return Head;

            return null;
        }

        //private bool Compare<T>(T Data,T Data2) where T : IComparable
        //{
        //    return Data.CompareTo(Data2) == 0;
        //}

        public bool Compare<T>(T x, T y)
        {
            return EqualityComparer<T>.Default.Equals(x, y);
        }


        public bool Contains(T Data)
        {
            bool result = false;
            DequeNode<T> tempNode = Head;

            while (tempNode != null)
            {
                if (Compare(Data, tempNode.data))
                {
                    result = true;
                    break;
                }
                else
                {
                    tempNode = tempNode.Next;
                }
            }

            return result;
        }

        public void Clear()
        {
            Head = null;
            //while (Head != null)
            //{
            //    Head = Head.Next;
            //}
            cnt = 0;
        }

        public int Count()
        {
            return cnt;
        }
    }
}
