using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Arens
{
    internal class Program
    {

        public static void IsGreaterThan100()
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            if (num>100)
            {
                Console.WriteLine("gadol");
            }
            else
            {
                if (num==100)
                {
                    Console.WriteLine("equal");
                }
                else
                {
                    Console.WriteLine("smaller");
                }
            }
        }

        public static void BoolIntro()
        {

           bool bool1 = true;
            Console.WriteLine(bool1);
           bool bool2 = false;
            Console.WriteLine(bool2);
        }
        

        public static void BoolIntro2()
        {

            bool boolResult;
            boolResult = 5 > 3;
            Console.WriteLine(boolResult);
            boolResult = 5 < 3;
            Console.WriteLine(boolResult);
        }
        public static void BoolOp()
        {
            bool b1 = 2 * 4 < 9 && 2 * 4 < 10;
            bool b2 = 2 * 4 > 12;
            Console.WriteLine(b1 && b2);
            Console.WriteLine(b1 || b2);
            Console.WriteLine(!b1);
            Console.WriteLine(!b2);
        }


        public static void Exc_1()
        {
            Console.WriteLine("Hi");
        }
        public static void Exc_2()
        {
            Console.WriteLine("Enter three grades");
            int grade1 = int.Parse(Console.ReadLine());
            int grade2 = int.Parse(Console.ReadLine());
            int grade3 = int.Parse(Console.ReadLine());
            double avg = (double)(grade1 + grade2 + grade3) / 3;
            Console.WriteLine($"Your average is {avg}");
        }
        public static void Ex11()
        {
            Console.WriteLine("enter side length: ");
            int side = int.Parse(Console.ReadLine());
            int area = side * side;
            int heikef = side * 4;
            Console.WriteLine($"the area is {area} the heikef is {heikef}");
        }
        public static void ex14()
        {
            Console.WriteLine("enter length: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter width: ");
            int side2 = int.Parse(Console.ReadLine());
            int area1 = side1 * side2;
            side1 = side1 * 2;
            side2 -= 1;
            int area2 = side1 * side2;
            Console.WriteLine($"the area is {area1} the area2 is {area2}");
            int diff = area1 - area2;
            Console.WriteLine(diff);
        }
            static void Main(string[] args)
        {
            //Exc_1();
            BoolIntro2();
        }
    }
}
