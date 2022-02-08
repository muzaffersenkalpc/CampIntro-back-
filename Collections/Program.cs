using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] {"Muzo", "Berko", "Tuna", "Cem" }; //4 elemanlı array.
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            //names = new string[5];



            List<string> names2 = new List<string> { "Muzo", "Berko", "Tuna", "Cem" }; //Dinamik dizi diyebiliriz. List.
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("muzo2");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
            
        }
    }
}
