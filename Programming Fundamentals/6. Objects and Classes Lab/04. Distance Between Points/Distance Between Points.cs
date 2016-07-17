using System;
using System.Linq;
using System.Collections.Generic;
    
using System.Globalization;

namespace _06.Reverse_the
{
    class Points
    {
        public Points(int Varx, int Vary)
        {
            x = Varx;
            y = Vary;
        }
        public int x { get; set; }
        public int y { get; set; }

        public double Calcdistance (Points p1, Points p2)
        {

            int sideX = Math.Abs(p1.x - p2.x);
            int sideY = Math.Abs(p1.y - p2.y);

            int Sides = (sideX * sideX) + (sideY * sideY);

            double distance = Math.Sqrt(Sides);

            return distance;
        }


        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();


            Points point1 = new Points(input1[0], input1[1]);
            Points point2 = new Points(input2[0], input2[1]);


            Console.WriteLine("{0:f3}",point1.Calcdistance(point1, point2));

        }
    }
}