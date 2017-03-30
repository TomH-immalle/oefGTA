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
            Voertuig brommer = new Brommer();
            Voertuig truck = new Vrachtwagen();
            Voertuig a = new Auto();
            Persoon i = new Persoon();
            v.Rij();
            v.Stop();
            //brommer.Rij();
            //truck.Rij();
            //truck.Stuur(50);
            a.Rij();
            a.Stuur(180);
            a.Stop();
            
            
        }
    }
}
