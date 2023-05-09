using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumeracao
{
    internal class Enumerador
    {
        // ENUMERADORES
        public enum meses
        {
            Janeiro, Fevereiro, Março, Abril,
            Maio, Junho, Julho, Agosto,
            Setembro, Outubro, Novembro, Dezembro
        }

        public enum move{cima, direita, baixo, esquerda}

        public void MostrarMes(meses mes)
        {
            MessageBox.Show($"O mês selecionado foi: {mes}");
        }

        public void Movimento(move direcao)
        {
            MessageBox.Show($"Movimentou para: {direcao}");
        }

    }
}
