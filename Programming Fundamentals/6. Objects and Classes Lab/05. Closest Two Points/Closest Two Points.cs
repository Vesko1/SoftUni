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

        public static double Calcdistance (Points p1, Points p2)
        {

            int sideX = Math.Abs(p1.x - p2.x);
            int sideY = Math.Abs(p1.y - p2.y);

            int Sides = (sideX * sideX) + (sideY * sideY);

            double distance = Math.Sqrt(Sides);

            return distance;
        }


        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());


            Points[] point = new Points[n];




            for (int i = 0; i < n; i++)
            {


                int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                
                var data = new Points(input1[0], input1[1]);
                point[i] = data;
            }
            double min_dis = double.MaxValue;

            var Point1 = new Points(0,0);
            var Point2 = new Points(0, 0);

            for (int q = 0; q < point.Length; q++)
            {

                for (int i = 0; i < point.Length; i++)
                {

                    if (!point[q].Equals(point[i]))
                    {




                double temp = Points.Calcdistance(point[q], point[i]);

                if (temp < min_dis)
                {
                    Point1.x = point[q].x;
                    Point1.y = point[q].y;

                    Point2.x = point[i].x;
                    Point2.y = point[i].y;

                    min_dis = temp;


                }

            }

          

                }

            }


            Console.WriteLine(min_dis);
            Console.WriteLine("({0} {1})", Point1.x , Point1.y);
            Console.WriteLine("({0} {1})", Point2.x, Point2.y);

        }
    }
}