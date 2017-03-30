using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefGTA
{
    class Persoon
    {
        public string Naam { get; set; }
        public bool Rijbewijs;
        public bool Identiteitskaart;
    }
    class Dief : Persoon
    {
        public void Gestolen()
        {
            Console2.WriteLine("Voertuig werd gestolen door " + Naam, ConsoleColor.White);

        }
    }
}