﻿using System;

namespace GenericsIntroBack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Muzo");
            Console.WriteLine(names.Length);

            names.Add("Muzo2");
            Console.WriteLine(names.Length);
            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
