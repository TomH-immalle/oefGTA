using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefGTA
{
    class Program
    {

        static void Main(string[] args)
        {
            Voertuig v = new Voertuig(ConsoleColor.Magenta);
            Brommer brommer = new Brommer();
            Voertuig truck = new Vrachtwagen();
            Auto a = new Auto();
            v.Rij();
            brommer.Rij();
            truck.Rij();
            truck.Stuur(50);
            a.Stuur(180);
        }
    }
}
