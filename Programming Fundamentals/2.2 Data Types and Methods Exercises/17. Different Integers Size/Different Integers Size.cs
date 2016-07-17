using System;
class Program
{
    static void Main()
    {

        string a = Console.ReadLine();

        sbyte sbyte1;
        byte byte1;
        short short1;
        ushort ushort1;
        int int1;
        uint uint1;
        long long1;


        bool shalter = false;

        if (sbyte.TryParse(a, out sbyte1))
        {
            
            if (shalter == false)
            {
                Console.WriteLine("{0} can fit in:", a);
                shalter = true;

            }
            Console.WriteLine("* sbyte");

        }
        if (byte.TryParse(a, out byte1))
        {
           
            if (shalter == false)
            {
                Console.WriteLine("{0} can fit in:", a);
                shalter = true;

            }
            Console.WriteLine("* byte");

        }
        if (short.TryParse(a, out short1))
        {
          
            if (shalter == false)
            {
                Console.WriteLine("{0} can fit in:", a);
                shalter = true;

            }
            Console.WriteLine("* short");

        }
        if (ushort.TryParse(a, out ushort1))
        {

          
            if (shalter == false)
            {
                Console.WriteLine("{0} can fit in:", a);
                shalter = true;

            }
            Console.WriteLine("* ushort");
        }
        if (int.TryParse(a, out int1))
        {
           
            if (shalter == false)
            {
                Console.WriteLine("{0} can fit in:", a);
                shalter = true;

            }
            Console.WriteLine("* int");

        }
        if (uint.TryParse(a, out uint1))
        {
            if (shalter == false)
            {
                Console.WriteLine("{0} can fit in:", a);
                shalter = true;

            }
            Console.WriteLine("* uint");

        }
        if (long.TryParse(a, out long1))
        {
           
            if (shalter == false)
            {
                Console.WriteLine("{0} can fit in:", a);
                shalter = true;

            }
            Console.WriteLine("* long");

        }
        if (shalter == false)
        {

            Console.WriteLine("{0} can't fit in any type", a);
        }



        //   a as int 
    }
}