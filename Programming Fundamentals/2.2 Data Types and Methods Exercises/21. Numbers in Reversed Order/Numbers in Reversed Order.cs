using System;
class Program
{
    static void Main()
    {

        string input = Console.ReadLine();

        char[] array = input.ToCharArray();

         Array.Reverse(array);

        Console.WriteLine(  string.Join(null, array));

    }
}