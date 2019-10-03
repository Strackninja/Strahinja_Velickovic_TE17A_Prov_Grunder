using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariatägarens_dotter
{
    class Bok
    {   //Alla Variabler som kommer att användas i denna Class, medföljer även en random generator.
        public int Price;
        string Name;
        int Rarity;
        string Genre;
        int actualValue;
        bool cursed;
        static Random genereator = new Random();
        int Evaluate;

        string[] names = //De namnen som används 
        {
            "Chris",
            "Amanda",
            "Alvin",
            "Strahinja",
            "Rasmus",
            "Anna",
        };

        string[] Genres =
        {
            "Comedy",
            "Detective story",
            "Fantasy",
            "Sci-Fi",
            "Dystopia",
            "Thriller",

        };

        public Bok(string BokNamn)
        {
            //Rarity och actualValue blir en random siffra från 1-10 (skrev in 11 då next(11) gör att siffran som retrurnas är mindre än det inskrivna numret)
            Rarity = genereator.Next(11);
            actualValue = genereator.Next(11);

            if (genereator.Next(11) > 2)
            {
                cursed = false;
            }

            else
            {
                cursed = true;
            }

            Name = BokNamn;
            Genre = Genres[genereator.Next(names.Length)];
        }

        //Skriver ut bokens information
        public void PrintInfo()
        {
            Console.WriteLine("Namn: {0}, \nGenre,  {1}\nBokens sällsynhet, {2}\nBokens värde, {3}", Name, Genre, Rarity, Price);
        }

        public int evaluate()
        {
            int BuyValue = actualValue * Rarity;
            //Returnerar en BuyValue mellan 50% och 150%
            return genereator.Next(BuyValue / 2, BuyValue * 15 / 10);
        }

        //returnerar Genren 
        public string GetGenre()
        {
            return Genre;
        }

        //returnerar namnet av boken 
        public string GetName()
        {
            return Name;
        }

        //80% chans att boken inte är cursed
        public bool IsCursed()
        {
            if (genereator.Next(0, 80) < 80)
            {
            }
            return cursed;


        }
    }
}
