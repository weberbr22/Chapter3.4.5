﻿using System;

namespace Chapter3._4._5
{
    class Program
    {

        static bool even(int n)
        {
            return n % 2 == 0 ? true : false;
        }

        static bool processor(int n)
        {
            return n % 5 == 0 && n % 7 == 0 ? true : false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Chapter 3!");
            int x = 3;
            int p = 35;
            Console.WriteLine(even(x));

            Console.WriteLine(processor(p));

            //test to see if this has worked on github
            //another test to see if this has worked on github
        }
    }
}

