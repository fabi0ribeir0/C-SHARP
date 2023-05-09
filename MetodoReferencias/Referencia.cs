using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoReferencias
{
    internal class Referencia
    {
        public void acrescentar(ref int v1)
        {
            v1 += 10;
        }
            
    }
}
