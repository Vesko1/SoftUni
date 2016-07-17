using System;
using System.Linq;
using System.Collections.Generic;
    
using System.Globalization;

namespace _06.Reverse_the
{


    public class Sale
    {

      
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        

    
        public static Sale ReadSale(string input)
        {
            string[] data = input.Split();

            return new Sale()
            {
                Town = data[0],
                Product = data[1],
                Price = decimal.Parse(data[2]),
                Quantity = decimal.Parse(data[3])

            };
                
                
        }
            
    }


    
    
    
    class Points
    {
    

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var SalesByTown = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                Sale input = Sale.ReadSale(Console.ReadLine());



                if (SalesByTown.ContainsKey(input.Town))
                {
                    SalesByTown[input.Town] += input.Price * input.Quantity;


                }
                else
                {
                    SalesByTown[input.Town] = input.Price * input.Quantity;
                }
            }




            foreach (var item in SalesByTown)
            {

                Console.WriteLine("{0} -> {1:F2}",  item.Key, item.Value);
            }   



        }
        

    }
}