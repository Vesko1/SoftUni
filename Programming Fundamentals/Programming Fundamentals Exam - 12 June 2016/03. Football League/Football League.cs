using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {

              string input = Console.ReadLine();

    
               int delimiter_lenght = input.Length;


            string[] stringSeparators = new string[] { input };

        
            Dictionary<string, int> CountryScores = new Dictionary<string, int>();
            Dictionary<string, int> CountryGoals = new Dictionary<string, int>();

            int StringStarts;
            int StringEnds;
            while (true)
            {
                string input_matches = Console.ReadLine();
           
                StringEnds = 0;
                StringStarts = 0;
                if (input_matches == "final")
                {

                    break;
                }

                StringStarts = input_matches.IndexOf(input) + delimiter_lenght;
                StringEnds = input_matches.IndexOf(input, StringStarts);
                string Substring = input_matches.Substring(StringStarts, StringEnds - StringStarts);

                char[] reverse = Substring.ToCharArray();

                Array.Reverse(reverse);

                string FirstFootBallTeam = new string(reverse).ToUpper();

                StringStarts = input_matches.IndexOf(input, StringEnds + delimiter_lenght) + delimiter_lenght;
                StringEnds = input_matches.IndexOf(input, StringStarts);
                Substring = input_matches.Substring(StringStarts, StringEnds - StringStarts);


                reverse = Substring.ToCharArray();

                Array.Reverse(reverse);

                string SecondFootBallTeam = new string(reverse).ToUpper();



                string Leftsubstring = input_matches.Substring(StringEnds+delimiter_lenght);
                string[] secondnumber = Leftsubstring.Split(':');

               
                string temp = Regex.Replace(secondnumber[0], "[^0-9]+", string.Empty);

                int FirstTeamResult = Convert.ToInt32(temp);
                int SecondTeamResult = Convert.ToInt32(secondnumber[1]);



                if (!CountryScores.ContainsKey(FirstFootBallTeam))
                {
                    
                   CountryScores.Add(FirstFootBallTeam, 0);
                }
                if (!CountryScores.ContainsKey(SecondFootBallTeam))
                {

                    CountryScores.Add(SecondFootBallTeam, 0);
                }



                if (CountryGoals.ContainsKey(FirstFootBallTeam))
                {
                    CountryGoals[FirstFootBallTeam] += FirstTeamResult;
                }
                else
                {
                    CountryGoals.Add(FirstFootBallTeam, FirstTeamResult);
                }



                if (CountryGoals.ContainsKey(SecondFootBallTeam))
                {
                    CountryGoals[SecondFootBallTeam] += SecondTeamResult;
                }
                else
                {
                    CountryGoals.Add(SecondFootBallTeam, SecondTeamResult);
                }






                if (FirstTeamResult > SecondTeamResult)
                {

                    if (CountryScores.ContainsKey(FirstFootBallTeam))
                    {
                        CountryScores[FirstFootBallTeam] += 3;
                    }
                    else
                    {
                        CountryScores.Add(FirstFootBallTeam, 3);
                    }


                }


                if (FirstTeamResult < SecondTeamResult)
                {

                    if (CountryScores.ContainsKey(SecondFootBallTeam))
                    {
                        CountryScores[SecondFootBallTeam] += 3;
                    }
                    else
                    {
                        CountryScores.Add(SecondFootBallTeam, 3);
                    }


                }
                if (FirstTeamResult == SecondTeamResult)
                {


                    if (CountryScores.ContainsKey(SecondFootBallTeam))
                    {
                        CountryScores[SecondFootBallTeam] += 1;
                    }
                    else
                    {
                        CountryScores.Add(SecondFootBallTeam, 1);
                    }

                    if (CountryScores.ContainsKey(FirstFootBallTeam))
                    {
                        CountryScores[FirstFootBallTeam] += 1;
                    }
                    else
                    {
                        CountryScores.Add(FirstFootBallTeam, 1);
                    }




                }





                }




            // Dictionary<string, int> CountryScores = new Dictionary<string, int>();

            // Dictionary<string, int> CountryGoals = new Dictionary<string, int>();


            var scores = CountryScores.OrderBy(x => x.Key).OrderByDescending(x => x.Value);
            int counter = 1;
            var goals = CountryGoals.OrderBy(x => x.Key).OrderByDescending(x => x.Value).Take(3);
            Console.WriteLine("League standings:");
            foreach (var item in scores)
            {

                Console.WriteLine("{0}. {1} {2}",counter, item.Key, item.Value);

                counter++;

            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var item in goals)
            {

                Console.WriteLine("- {0} -> {1}", item.Key, item.Value);
            }




        }



    }
}
