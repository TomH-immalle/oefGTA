using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefGTA
{
    class Brommer : Voertuig
    {
        public Brommer() : base(ConsoleColor.DarkYellow)
        {
        }

        public override void Rij()
        {
            Console2.WriteLine("De brommer rijdt...", ConsoleColor.Blue);
        }
    }
}
