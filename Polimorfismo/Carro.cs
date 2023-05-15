using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    internal class Carro : Veiculos
    {
        public string radiador { get; set; }

        public override void acelerar()
        {
            MessageBox.Show("Carro acelerou");
        }
    }
}
