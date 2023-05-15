using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    abstract class Veiculos
    {
        public string cor { get; set; }
        public string modelo { get; set; }

        abstract public void acelerar();
    }
}
