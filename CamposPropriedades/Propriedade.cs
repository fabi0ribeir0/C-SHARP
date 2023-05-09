using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamposPropriedades
{
    internal class Propriedade
    {
        string _nome;

        public string NOME
        {
            set
            {
                if (value == "joao")
                {
                    _nome = "Este nome não é permitido";
                }
                else
                {
                    _nome = value;

                }
            } 
            get
            {
                return _nome;
            }
        }
        
        public void mostrar()
        {
            MessageBox.Show(_nome);
        }
    }
}
