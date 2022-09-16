using System;

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

        static bool is7(int n)
        {
            int x;
            int y;
            x = n / 100;
            y = x % 10;
            return y == 7 ? true : false;
        }

        static bool Getbit(int BitNumber)
        {
            bool bit = (BitNumber & 8) != 0;
            return bit;
        }

        static int Trapeziod(int a, int b, int h)
        {
            int area;
            area = ((a + b) * h) / 2;
            return area;
        }

        static int Rectangle()
        {
            int a;
            int b;
            Console.WriteLine("Enter height: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            b = Int32.Parse(Console.ReadLine());
            int area = a * b;
            return area;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Chapter 3!");
            //test to see if this has worked on github
            //another test to see if this has worked on github
            Console.WriteLine(even(3));
            Console.WriteLine(processor(35));
            Console.WriteLine(is7(701));
            Console.WriteLine(Getbit(25));
            Console.WriteLine(Trapeziod(2, 3, 5));
            Console.WriteLine(Rectangle());
        }
    }
}

