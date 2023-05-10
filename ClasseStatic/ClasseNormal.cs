using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseStatic
{
    internal class ClasseNormal
    {
        public string nome { set; get; }

        public void MostraNome()
        {
           
            MessageBox.Show(nome);
        }    
    }
}
