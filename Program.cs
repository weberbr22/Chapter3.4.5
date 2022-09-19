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
        static int isLargest()
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
            int output = 0;
            if (x > y && x>a && x>b && x > c)
            {
                 output = x;
            }
            else if (y > x && y > a && y > b && y > c)
            {
                output = y;
            }
            else if (a > y && a > x && a > b && a > c)
            {
                output = a;
            }
            else if (b > y && b > a && b > x && b > c)
            {
                output = b;
            }
            else if (c > y && c > a && c > b && c > x)
            {
                output = c;
            }
            else
            {

            }
            return output;
        }
        static string isGreater()
        {
            Console.WriteLine("What is the first num: ");
            var x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the second num: ");
            var y = Int32.Parse(Console.ReadLine());
            int carry;
            if (x > y)
            {
                carry = x;
                x = y;
                y = carry;
            }
            else { }
            string output = ("x = " + x + "y = " + y);
            return output;
        }
        static string whatSign()
        {
            Console.WriteLine("What is the first num: ");
            var x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the second num: ");
            var y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the third num: ");
            var z = Int32.Parse(Console.ReadLine());
            int negcount = 0;
            string output;
            if (x < 0) {negcount = negcount + 1;}
            if (y < 0) {negcount = negcount + 1;}
            if (z < 0) { negcount = negcount + 1;}
            if (x == 0 ^ y==0 ^ z == 0) {negcount = -1;}

            if (negcount % 2 == 0) {output = ("Positive");}
            else if (negcount % 2 == 1) {output = ("Negative");}
            else if (negcount == -1) {output = ("0");}
            else {output = ("Nothing");}

            return output;
        }
        static int biggest()
        {
            Console.WriteLine("What is the first num: ");
            var x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the second num: ");
            var y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the third num: ");
            var a = Int32.Parse(Console.ReadLine());
            int output;
            if (x > y && x > a)
            {
                output = x;
            }
            else if (y > x && y > a)
            {
                output = y;
            }
            else if (a > y && a > x)
            {
                output = a;
            }
            else
            {
                output = 0;
            }
            return output;
        }
        static string sort()
        {
            Console.WriteLine("What is the first num: ");
            var x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the second num: ");
            var y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the third num: ");
            var a = Int32.Parse(Console.ReadLine());
            string output;
            int carry;
            int carry1;
            if (x > y && x > a && y>a)
            {
                output = (x+" "+y+" "+a);
            }
            else if (x > y && x > a && a > y)
            {
                carry = a;
                a = y;
                y = carry;
                output = (x + " " + y + " " + a);
            }
            else if (y > x && y > a && x > a)
            {
                carry = x;
                x = y;
                y = carry;
                output = (x + " " + y + " " + a);
            }
            else if (y > x && y > a && x > a)
            {
                carry = x;
                x = y;
                carry1 = a;
                y = carry1;
                a = carry;
                output = (x + " " + y + " " + a);
                //Just realised this can be much more simple
            }
            else if (a > x && a > y && x > y)
            {
                output = (a + " " + x + " " + y);
            }
            else if (a > x && a > y && y > x)
            {
                output = (a + " " + y + " " + x);
            }
            else
            {
                output = ("Nothing");
            }
            return output;
        }
        static string quadform()
        {
            Console.WriteLine("What is the first num: ");
            var a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the second num: ");
            var b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the third num: ");
            var c = Int32.Parse(Console.ReadLine());
            double root1;
            double root2;

            root1 = ((-b + Math.Sqrt((b * b) - 4 * a * c)) / 2 * a);
            root2 = ((-b - Math.Sqrt((b * b) - 4 * a * c)) / 2 * a);

            string output = (root1 + ", " + root2);
            return output;
        }

        static void user_choice()
        {
            Console.WriteLine("Enter 1 for int, 2 for double or 3 for string: ");
            var q = Int32.Parse(Console.ReadLine());
            switch (q)
            {
                case 1:
                    Console.WriteLine("Enter Here: ");
                    int carry = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(carry + 1);
                    break;

                case 2:
                    Console.WriteLine("Enter Here: ");
                    double carry1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(carry1 + 1);
                    break;

                case 3:
                    Console.WriteLine("Enter Here: ");
                    string carry2 = Console.ReadLine();
                    Console.WriteLine(carry2 + "*");
                    break;

            }
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
            Console.WriteLine(isLargest());

            Console.WriteLine("Hello Chapter 5!");
            Console.WriteLine(isGreater());
            Console.WriteLine(whatSign());
            Console.WriteLine(biggest());
            Console.WriteLine(sort());
            Console.WriteLine(quadform());
            user_choice();
            

            
        }
    }
}

