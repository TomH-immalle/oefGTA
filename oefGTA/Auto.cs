using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefGTA
{
    class Auto : Voertuig
    {
        public Auto() : base(ConsoleColor.DarkYellow)
        {
        }

        public override void Rij()
        {
            Console2.WriteLine("De auto rijdt...", ConsoleColor.Red);
        }
        public override void Stuur(int graden)
        {
            Console.WriteLine("De chauffeur kijkt in zijn achtruitkijk spiegel");
            base.Stuur(graden);
        }
    }
}
