using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
         
            foreach(string s in list)
                Console.WriteLine(s);
            Console.WriteLine("\n*************************\n");
            list.Insert(0, "Marcos");
            list.Insert(0, "Matheus");
            list.Insert(0, "Iagatha");
         
            foreach(string s in list)
                Console.WriteLine(s);
            Console.WriteLine("\n*************************\n");

            Console.WriteLine("list count: " + list.Count);
            Console.WriteLine("\n*************************\n");

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro A: " + s1);
            Console.WriteLine("\n*************************\n");

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Primeiro A: " + s2);
            Console.WriteLine("\n*************************\n");

            DateTime data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine("\n*************************\n");
        }
    }
}