﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animale
    {
        
        
        public abstract void Verso();

        
        public void Dormi()
        {
            Console.WriteLine("Zzz");
        }

        public abstract void CosaMangi();
    }
    
}
