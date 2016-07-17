using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            decimal total = 0;
            decimal price = 0;
            for (int i = 0; i < n; i++)
            {

                decimal price_per_capsule = decimal.Parse(Console.ReadLine());
                DateTime order_date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int Capsules_count = int.Parse(Console.ReadLine());

                decimal days_in_month = DateTime.DaysInMonth(order_date.Year, order_date.Month);

                decimal substract = order_date.Day;
                price = ((days_in_month) * Capsules_count) * price_per_capsule;

            

                total += price;


                // ((daysInMonth * capsulesCount) * pricePerCapsule)
                Console.WriteLine("The price for the coffee is: ${0:f2}", price);
            }



            Console.WriteLine("Total: ${0:f2}", total);

        }
    }
}