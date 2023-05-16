using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseVirtual
{
    internal class Carro : ClasseMaster
    {
        public override void Buzinar()
        {
            MessageBox.Show("Carro Buzinou");
        }
    }
}
