using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Program
    {
        enum Days { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
        enum Month { January, February, March, April, May, June, July, August, September, October, November, December };
        
        struct RGB
        {
            public byte r;
            public byte g;
            public byte b;

            public override string ToString() => $"(r={r}, g={g}, b={b})";
        }
        
        struct Dog
        {

            public Dog(string name, string mark, int age)
            {
                this.name= name ;
                this.mark= mark ;
                this.age= age ;
            }
            public string name;
            public string mark;
            public int age;
            public override string ToString() => $"Dog Name={name}, Dog mark={mark}, Dog age={age}";

        }

        static void Main(string[] args)
        {
            //task 1
            Console.WriteLine("Enter day of week number");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month number");
            int m = int.Parse(Console.ReadLine());

            if (d >= 0 && d <= 6)
            {
                Days day = (Days)d;
                Console.WriteLine("Day is {0}", day);
            }
            else
            {
                Console.WriteLine("Day out range");
            }

            if (m >= 0 && m <= 11)
            {
                Month month = (Month)m;
                Console.WriteLine("Month is {0}", month);
            }
            else
            {
                Console.WriteLine("Month out range");
            }
            Console.ReadLine();


            task 2 to do
                //674.8622
                Console.WriteLine("enter number");
            double dNumber = double.Parse(Console.ReadLine());
            double temDouble = dNumber - Math.Truncate(dNumber);

            double a = Math.Truncate(temDouble * 10);

            temDouble = temDouble * 10 - Math.Truncate(temDouble * 10);
            double b = Math.Truncate(temDouble * 10);

            Console.WriteLine("{0}+{1}={2}", a, b, (a + b));

            task 3 to do
                Console.WriteLine("enter hour of day");
            int h = int.Parse(Console.ReadLine());
            if (0 <= h && h <= 6)
            {
                Console.WriteLine("Good morning!");
            }
            else if (6<h && h<12)
            {
                Console.WriteLine("Good afternoon!");
            }
            else if (12 <= h && h <=18)
            {
                Console.WriteLine("Good evening!");
            }
            else
            {
                Console.WriteLine("Good night!");
            }

            //task 4
            string test1Status = TestCaseStatus.Pass.ToString();
            Console.WriteLine(test1Status);
            Console.ReadLine();

            //task 5
            RGB rgbWhite = new RGB();
            rgbWhite.r = 255;
            rgbWhite.g = 255;
            rgbWhite.b = 255;

            RGB rgbBlack = new RGB();
            rgbBlack.r = 0;
            rgbBlack.g = 0;
            rgbBlack.b = 0;

            Console.WriteLine("White RGB {0}", rgbWhite.ToString());
            Console.WriteLine("Black RGB r={0},g={1},b={2}", rgbBlack.r, rgbBlack.g, rgbBlack.b);
            Console.ReadLine();

            //Home Work 2 1
            bool inBracket = true;

            for (int i = 0; i < 3; i++)
            {
                float number = float.Parse(Console.ReadLine());
                if (number > 5 || number < -5)
                {
                    inBracket = false;
                }

            }
            if (inBracket)
            {
                Console.WriteLine("all good");
            }
            else
            {
                Console.WriteLine("Not Good");
            }



            //homework task 2

            int number = int.Parse(Console.ReadLine());
            int max = number;
            int min = number;

            for (int i = 0; i < 2; i++)
            {

                number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }

            }
            Console.WriteLine("Min {0} Max {1}", min, max);

            //Homework Task3

            Console.WriteLine("Enter Code HTTP Status");

            int code = int.Parse(Console.ReadLine());

            Console.WriteLine((HttpStatusCode)code);

           // Homework Task4

            Console.WriteLine("enter dog name");
            string name = Console.ReadLine();

            Console.WriteLine("enter dog mark");
            string mark = Console.ReadLine();

            Console.WriteLine("enter dog age");
            int age = int.Parse(Console.ReadLine());

            Dog myCoolDog = new Dog(name, mark, age);

            Console.WriteLine(myCoolDog.ToString());



            Console.ReadLine();
           
        }
    }
}
