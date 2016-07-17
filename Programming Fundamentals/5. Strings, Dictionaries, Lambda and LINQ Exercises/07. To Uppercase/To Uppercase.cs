using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Reverse_the
{
    class Program
    {
        static void Main(string[] args)
        {

            
            char[] separators = new char[] { ' ', '>' };

            string input = Console.ReadLine();


            StringBuilder sb = new StringBuilder(input);



            int parvi_tag = 0;


            while (true)
            {

                parvi_tag = sb.ToString().IndexOf("<upcase>");

                if (parvi_tag == -1)
                {
                    break;
                }

                int zatvarqst_tag = sb.ToString().IndexOf("</upcase>");
                int text_to_change = parvi_tag + 8;
                int text_to_delete = zatvarqst_tag + 9;
                int daljina_to_upper = zatvarqst_tag - text_to_change;

                string ToUpper = sb.ToString().Substring(text_to_change, daljina_to_upper).ToUpper();


                sb.Remove(parvi_tag, text_to_delete - parvi_tag);

                sb.Insert(parvi_tag, ToUpper);


            }

            Console.WriteLine(sb.ToString());

        }
    }
}