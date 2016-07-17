using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

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
        public DateTime Release_Date { get; set; }
        public int  ISBN { get; set; }
        public decimal Price { get; set; }



        public static Book ReadBook(string input)
        {

            string[] rawlist = input.Split();

           
            return new Book() {title = rawlist[0], author = rawlist[1], publisher = rawlist[2], Release_Date = DateTime.ParseExact(rawlist[3], "dd.MM.yyyy", CultureInfo.InvariantCulture), ISBN = int.Parse(rawlist[4]), Price = decimal.Parse(rawlist[5]) };
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


            DateTime release = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var test1 = Author.Books.Where(x => x.Release_Date > release).OrderBy(x => x.Release_Date).ThenBy(x => x.title);


             Dictionary<string, decimal> result = new Dictionary<string, decimal>();

   
            foreach (var item in test1)
            {
                Console.WriteLine("{0} -> {1:dd.MM.yyyy}", item.title, item.Release_Date);

            }
        }

    }
}
