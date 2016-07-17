using System;
using System.Linq;
using System.Collections.Generic;

using System.Globalization;

namespace _06.Reverse_the
{





    public class Student
    {
        public string Name { get; set; }
     //   public int[] Grades { get; set; }
        public decimal Average { get; set; }

        //public static int  CalculateAverageGrade(int[] input)
        //{

        //    return 3;
        //}

        public static Student ReadStudent(string input)
        {

            string[] rawlist = input.Split();

            decimal[] Grades = rawlist.Skip(1).Select(decimal.Parse).ToArray();


            decimal marks = Grades.Average();

            return new Student() {Name = rawlist[0], Average = marks };
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> list = new List<Student>();

            for (int i = 0; i < n; i++)
            {

                Student student = Student.ReadStudent(Console.ReadLine());

                if (student.Average >= 5m)
                {
                    list.Add(student);
                }
            }



            var sortedList = list.OrderByDescending(u => u.Average).OrderBy(x => x.Name);

            foreach (var item in sortedList)
            {
                Console.WriteLine("{0} -> {1:f2}", item.Name, item.Average);
            }

        }


    }
}