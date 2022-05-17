using System;
using System.Collections.Generic;

namespace CS_Data_Struct
{
    class Program
    {
        static int fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return fibonacci(n - 1) + fibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            List_Soon<int> test = new List_Soon<int>();

            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(5);
            test.Add(6);
            test.Add(7);
            test.Add(8);
            test.Add(9);
            test.Add(10);
            test.Add(11);
            test.Add(21);
            test.Add(22);
            test.Add(23);
            test.Add(24);
            test.Add(25);
            test.Add(26);
            test.Add(27);
            test.Add(28);
            test.Add(29);
            test.Add(210);
            test.Add(211);


            test.Add(100);


            test.Remove(2);

            Console.WriteLine(test.Remove(10));
            
            
            

        }
    }
}
