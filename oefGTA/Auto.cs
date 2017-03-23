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
            Console.WriteLine("De auto draait {0} graden en de chauffeur kijkt in zijn achtruitkijk spiegel", graden);
            base.Stuur(graden);
        }
        public override void Stop()
        {
            Console2.WriteLine("De auto stopt...", ConsoleColor.Red);
        }
    }
}
