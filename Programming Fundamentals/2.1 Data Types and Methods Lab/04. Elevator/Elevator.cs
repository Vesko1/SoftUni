using System;

public class Substring_broken
{
    public static void Main()
    {

        int people = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());


        int courses = (int)Math.Ceiling((double)people / capacity);



        Console.WriteLine(courses);

    }
}