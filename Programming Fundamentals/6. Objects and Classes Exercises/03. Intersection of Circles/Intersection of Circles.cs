using System;
using System.Linq;
using System.Collections.Generic;

using System.Globalization;

namespace _06.Reverse_the
{


    public class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }


       public static Circle ReadCircle(string input)
        {
            int[] tokens = input.Split(' ').Select(int.Parse).ToArray();
            return new Circle { Center = new Point { X = tokens[0], Y = tokens[1] }, Radius = tokens[2] };
        }


    }


    public class Point
    {


        public int X { get; set; }
        public int Y { get; set; }

        public bool Intersect(Circle c1, Circle c2)
        {

            return true;


        }


        static void Main(string[] args)
        {


            Circle circle1 = Circle.ReadCircle(Console.ReadLine());
            Circle circle2 = Circle.ReadCircle(Console.ReadLine());

            
            double d = Math.Sqrt((circle2.Center.X - circle1.Center.X) * (circle2.Center.X - circle1.Center.X) + (circle2.Center.Y - circle1.Center.Y) * (circle2.Center.Y - circle1.Center.Y));


            if ( d <= circle1.Radius + circle2.Radius)
            {
                Console.WriteLine("Yes");

            }
            else
            {
                Console.WriteLine("No");
            }


        }


    }
}