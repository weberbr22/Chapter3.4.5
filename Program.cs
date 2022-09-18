using System;

namespace Chapter
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

        static string MoonWeight()
        {
            Console.WriteLine("What is your Earth Weight");
            int Carry = Int32.Parse(Console.ReadLine());
            double Moon = Carry * 0.17;
            string output = ("Your Moon Weight is: " + Moon);
            return output;
        }

        static bool OnCircle()
        {
            Console.WriteLine("What is the X Point: ");
            var x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the Y Point: ");
            var y = Int32.Parse(Console.ReadLine());
            if (x * x + y * y == 25)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static bool InShapes()
        {
            Console.WriteLine("What is the X Point: ");
            var x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the Y Point: ");
            var y = Int32.Parse(Console.ReadLine());
            if (x * x + y * y < 25 && x < 5 && x > -1 && y < 5 && y > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int Sum()
        {
            Console.WriteLine("What is the first num: ");
            var x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the second num: ");
            var y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the third num: ");
            var z = Int32.Parse(Console.ReadLine());
            int Sum = x + y + z;
            return Sum;
        }

        static string radius()
        {
            Console.WriteLine("What is the radius? ");
            var radius = Int32.Parse(Console.ReadLine());
            double area = (radius * radius) * Math.PI;
            double peri = (radius * Math.PI);
            string output = ("Area = " + area + " Perimeter = " + peri);
            return output;
        }

        static void inbetween()
        {
            Console.WriteLine("What is the first num: ");
            var x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the second num: ");
            var y = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < (y - x); i++)
            {
                if (i % 5 == 0)
                {
                    string e = Convert.ToString(i);
                    Console.WriteLine(e);
                    // I tried to make it work with a list
                    // but it said my version of c# is too old
                }
                else
                {
                    //nothing
                }

            }
        }
        static string islarger()
        {
            Console.WriteLine("What is the first num: ");
            var x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the second num: ");
            var y = Int32.Parse(Console.ReadLine());
            string output;
            if (x-y > 0)
            {
                output = ("The Larger Number is " + x);
            }
            else if (x - y < 0)
            {
                output = ("The Larger Number is " + y);
            }
            else
            {
                output = ("The Numbers are equal");
            }
            return output;
        }
        static string sum5()
        {
            Console.WriteLine("What is the first num: ");
            var x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the second num: ");
            var y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the third num: ");
            var a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the fourth num: ");
            var b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the fifth num: ");
            var c = Int32.Parse(Console.ReadLine());

            int total = x + y + a + b + c;
            string output = Convert.ToString(total);

            return output;
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
            Console.WriteLine(MoonWeight());
            Console.WriteLine(OnCircle());
            Console.WriteLine(InShapes());

            Console.WriteLine("Hello Chapter 4!");
            Console.WriteLine(Sum());
            Console.WriteLine(radius());
            inbetween();
            Console.WriteLine(islarger());
            Console.WriteLine(sum5());
        }
    }
}

