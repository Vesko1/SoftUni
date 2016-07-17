using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var holidaysCount = 0;

        for (var date = startDate; date <= endDate;)
        {
           
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                //Console.WriteLine(date.DayOfWeek);
                holidaysCount++;
            }
            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                date = date.AddDays(5);


            }
            else
            {
                date = date.AddDays(1);
            }
        }


        Console.WriteLine(holidaysCount);

    }
}