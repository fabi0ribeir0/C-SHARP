using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodop2
{
    internal class NomeCompleto
    {
        public string nome, sobreNome;

        public void NomeInteiro()
        {
            MessageBox.Show(Resposta());
        }

        private string Resposta()
        {
            string completo = nome + " " + sobreNome;
            return completo;
        }
    }
}
