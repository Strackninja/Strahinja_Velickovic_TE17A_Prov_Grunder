using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariatägarens_dotter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Val som spelaren ska kunna göra när de väl har "gjort" en bok
            string[] bokval =
            {
                "Info",
                "Name",
                "Genre",
                "Worth",
                "Cursed",

            };

            Console.WriteLine("Välkommen till Antikvariatägarens dotter");
            Console.WriteLine("Välj ett namn på din första bok");

            string BokNamn = Console.ReadLine();
            //Ligger under eftersom att BokNamn inte kan användas innan den är declared
            Bok förstabok = new Bok(BokNamn);




        }
    }
}
