using System;
using System.Linq;
using System.Collections.Generic;
    
using System.Globalization;

namespace _06.Reverse_the
{


    public class Rechtangle
    {

      
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Right  { get; set; }
        public int Bottom { get; set; }

        public static bool IsInside(Rechtangle r1, Rechtangle r2)
        {

            if (r1.Left >= r2.Left && r1.Right <= r2.Right && r1.Top <= r2.Top && r1.Bottom <= r2.Bottom)

            {

                return true;
            }
            
                return false;
            
        }


    }


    

    
    class Points
    {
    

        static void Main(string[] args)
        {

            Rechtangle point1 = ReadRechtangle(Console.ReadLine());
            Rechtangle point2 = ReadRechtangle(Console.ReadLine());


            if (Rechtangle.IsInside(point1, point2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }



        }

        static Rechtangle ReadRechtangle(string points)
        {

            int[] properties = points.Split().Select(int.Parse).ToArray(); 


            return new Rechtangle() { Left = properties[0], Top = properties[1], Width = properties[2], Height = properties[3], Right = properties[0] + properties[2], Bottom = properties[1] + properties[3]  };

        }


    }
}