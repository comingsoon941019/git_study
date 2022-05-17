using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CS_Data_Struct
{
    public class ListNode<T>
    {
        public T data { get; set; }
        public ListNode<T> Next { get; set; }
    }

    public class List_Soon<T>
    {
        private int m_def_size = 10;
        private int m_index = 0;
        T[] List_Array;

        public List_Soon()
        {
            List_Array = new T[m_def_size];
        }

        public void Add(T a_data)
        {
            if (m_index>=m_def_size)
            {
                Array.Resize(ref List_Array, m_def_size * 2);
                m_def_size = m_def_size * 2;
            }

            List_Array[m_index] = a_data;

            m_index++;
        }

        public T Get(int index)
        {
            if (index >= m_index)
            {
                throw new Exception("error");
            }
            return List_Array[index];
        }

        public bool Remove(int index)
        {
            if (index >= m_index)
                return false;

            if (m_index <= 0)
                return false;

            for (int i = index; i < m_index-1; i++)
            {
                List_Array[i] = List_Array[i+1];
            }

            m_index--;

            return true;
        }
        
        public int Size()
        {
            return m_index;
        }
    }
}