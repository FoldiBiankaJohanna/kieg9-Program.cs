using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kieg9
{
    class Program
    {
        static void Main(string[] args)
        {
            Szokinyero szokinyero = new Szokinyero("Ezt a mondatot fogjuk felbontani szavakra.");
            Console.WriteLine(szokinyero.Szoveg);

            szokinyero.Felvag();

            szokinyero.Megjelenit();

            szokinyero.VegetTisztit();

            szokinyero.Megjelenit();


            szokinyero.Rendez();

            szokinyero.Megjelenit();


        }
    }
}
