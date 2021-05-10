using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> md = new MyDictionary<int,string>();
            md.Add(111,"Muhammet");
            md.print();

        }
    }
}
