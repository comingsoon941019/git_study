using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Data_Struct
{
    class Node<T>
    {
        public T data { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Pre { get; set; }
    }


    class LinkedList_Soon<T>
    {
        Node<T> Head;

        public void Add(T a_data)
        {
            if(Head == null)
            {
                this.Head = new Node<T>();

                this.Head.data = a_data;
                this.Head.Next = null;
                this.Head.Pre = null;
            }
            else
            {
                Node<T> newNode = new Node<T>();
                newNode.data = a_data;
                
                Node<T> tempNode = Head;
                
                Head = newNode;
                Head.Next = tempNode;
                tempNode.Pre = Head;

                //Node<T> newNode = new Node<T>();
                //
                //newNode.Pre = Head;
                //newNode.Next = Head.Next;
                //newNode.Pre.Next = newNode;
                //newNode.Next.Pre = newNode;

            }
        }

        public void Print()
        {
            while (Head != null)
            {
                Console.WriteLine(Head.data);
                Head = Head.Next;
            }
        }

        public Node<T> current()
        {
            return Head;
        }

        public void Delete()
        {
            if (Head != null)
            {
                Head = Head.Next;
                Head.Pre = null;
            }
        }

    }
}
