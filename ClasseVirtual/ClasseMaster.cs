using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseVirtual
{
    abstract class ClasseMaster
    {
        //Metodo Virtual

        public virtual void Buzinar()
        {
            MessageBox.Show("Buzinou");
        }
    }
}
