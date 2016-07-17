using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{

    public class Library
    {

        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
    

    public class Book

   {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string Release_Date { get; set; }
        public int  ISBN { get; set; }
        public decimal Price { get; set; }



        public static Book ReadBook(string input)
        {

            string[] rawlist = input.Split();

           
            return new Book() {title = rawlist[0], author = rawlist[1], publisher = rawlist[2], Release_Date = rawlist[3], ISBN = int.Parse(rawlist[4]), Price = decimal.Parse(rawlist[5]) };
        }



        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Library Author = new Library() { Books = new List<Book>() };

            for (int i = 0; i < n; i++)
            {

                Book book = ReadBook(Console.ReadLine());

                Author.Books.Add(book);


            }



            
             Dictionary<string, decimal> result = new Dictionary<string, decimal>();
           
            foreach (var item in Author.Books)
            {

                if (result.ContainsKey(item.author))

                {
                    result[item.author] += item.Price;


                }
                else
                {
                    result[item.author] = item.Price;

                }
            }

            var ordered = result.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var item in ordered)
            {
                Console.WriteLine("{0} -> {1:f2}", item.Key, item.Value);

            }
        }

    }
}
