using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Data_Struct
{
    class stackNode<T>
    {
        public T data { get; set; }
        public stackNode<T> Next { get; set; }
    }

    class Stack_Soon<T>
    {
        stackNode<T> Head;
        int cnt = 0;

        public void Push(T a_data)
        {
            if (Head == null)
            {
                this.Head = new stackNode<T>();

                this.Head.data = a_data;
                this.Head.Next = null;
            }
            else
            {
                stackNode<T> newNode = new stackNode<T>();
                newNode.data = a_data;

                stackNode<T> tempNode = Head;

                Head = newNode;
                Head.Next = tempNode;

            }

            cnt++;
        }

        public void Print()
        {
            while (Head != null)
            {
                Console.WriteLine(Head.data);
                Head = Head.Next;
            }
        }

        public stackNode<T> Pop()
        {
            if (Head == null) return null;

            stackNode<T> popNode = Head;
            Head = Head.Next;

            cnt--;

            return popNode;
        }

        public stackNode<T> Peek()
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


        public bool Contains (T Data)
        {
            bool result = false;
            stackNode<T> tempNode = Head;

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
