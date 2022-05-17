using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Data_Struct
{
    class queueNode<T>
    {
        public T data { get; set; }
        public queueNode<T> Next { get; set; }
    }

    class Queue_Soon<T>
    {
        queueNode<T> Head;
        queueNode<T> Tail;
        int cnt = 0;

        public void Enqueue(T a_data)
        {
            if (Head == null)
            {
                this.Head = new queueNode<T>();

                this.Head.data = a_data;
                this.Head.Next = null;
                Tail = Head;
            }
            else
            {
                queueNode<T> newNode = new queueNode<T>();
                newNode.data = a_data;

                Tail.Next = newNode;
                Tail = newNode;


                //if (Last != null) Last = tempNode;
            }

            cnt++;
        }

        public void Print()
        {
            queueNode<T> tempNode = Head;

            while (tempNode != null)
            {
                Console.WriteLine(tempNode.data);
                tempNode = tempNode.Next;
            }
        }

        public queueNode<T> Dequeue()
        {
            if (Head == null) return null;

            queueNode<T> DeqNode = Head;

            Head = Head.Next;

            cnt--;
            return DeqNode;
        }

        public queueNode<T> Peek()
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
            queueNode<T> tempNode = Head;

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
