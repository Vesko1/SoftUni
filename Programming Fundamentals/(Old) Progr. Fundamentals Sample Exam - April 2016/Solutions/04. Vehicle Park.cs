using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
class ThreeBrothers
{



    static void Main()

   {



       string input = Console.ReadLine();

       List<string> notsold = new List<string>();

       string[] cars = input.Split(' ');

       List<string> customers = new List<string>();

        string[] temp = new string[1];
        string text = "";
        while (text != "End of customers!")
        {

            text = Console.ReadLine();

            temp = text.Split(' ');


            customers.Add((temp[0][0] + temp[2]).ToLower());
           
       
        }

        customers.Remove("ecustomers!");
        for (int i = 0; i < cars.Length; i++)
        {
            int tempsumme = 0;
           if (customers.Contains(cars[i]))
           {

              if ( cars[i][0] == 'c' )
              {
                  tempsumme = (int)cars[i][0] * Convert.ToInt32(cars[i].Substring(1));


              }
              if (cars[i][0] == 'v')
              {
                  tempsumme = (int)cars[i][0] * Convert.ToInt32(cars[i].Substring(1));


              }
              if (cars[i][0] == 'b')
              {
                  tempsumme = (int)cars[i][0] * Convert.ToInt32(cars[i].Substring(1));


              }

              customers[customers.IndexOf(cars[i])] = string.Format("Yes, sold for {0}$", tempsumme);
              cars[i] = 'Y'+tempsumme.ToString();



           }
           else
           {

               notsold.Add(cars[i]);
           }
            
        }

        int yes = 0;

        for (int i = 0; i < customers.Count; i++)
        {
            if (customers[i][0] == 'Y')
            {
                Console.WriteLine(customers[i]);
                yes++;
            }
            else
            {

                Console.WriteLine("No");
               
            }



        }

   
        Console.WriteLine("Vehicles left: {0}", string.Join(", ", notsold));
        Console.WriteLine("Vehicles sold: {0}", yes);


    }

    
}