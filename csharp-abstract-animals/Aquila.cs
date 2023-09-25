using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale, Ivolante
    {
        public override void Verso()
        {
            Console.WriteLine("Screech!");
        }

        public override void CosaMangi()
        {
            Console.WriteLine("Mangia prede come pesci o piccoli animali.");
        }

        public void Vola()
        {
            Console.WriteLine("Sto volando!!!");
        }
    }
}
