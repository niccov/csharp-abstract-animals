using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale, Ivolante
    {
        public override void Verso()
        {
            Console.WriteLine("Cip cip!");
        }

        public override void CosaMangi()
        {
            Console.WriteLine("Mangia semi e insetti.");
        }

        public void Vola()
        {
            Console.WriteLine("Sto volando!!!");
        }
    }
}
