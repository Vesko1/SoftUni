using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
class ThreeBrothers
{



    static void Main()

   {

       decimal us_price = decimal.Parse(Console.ReadLine());
       decimal us_box = decimal.Parse(Console.ReadLine());

       decimal uk_price = decimal.Parse(Console.ReadLine());
       decimal uk_box = decimal.Parse(Console.ReadLine());

       decimal cn_price = decimal.Parse(Console.ReadLine());
       decimal cn_box = decimal.Parse(Console.ReadLine());

       
       decimal us_per_kg = (us_price / 0.58m) / us_box;
       decimal uk_per_kg = (uk_price / 0.41m) / uk_box;
       decimal cn_per_kg = (cn_price * 0.27m) / cn_box;

       decimal min_price = us_per_kg;
       decimal max_price = us_per_kg;

       string store = "US";

        if (min_price > uk_per_kg)
        {

            min_price = uk_per_kg;
            store = "UK";
        }
        if (min_price > cn_per_kg)
        {

            min_price = cn_per_kg;
            store = "Chinese";
        }

        if (max_price < uk_per_kg)
        {

            max_price = uk_per_kg;
        }
        if (max_price < cn_per_kg)
        {

            max_price = cn_per_kg;
        }



        Console.WriteLine("{0} store. {1:F2} lv/kg ", store, min_price);
        Console.WriteLine("Difference {0:F2} lv/kg", Math.Abs(max_price-min_price));



    }

    
}