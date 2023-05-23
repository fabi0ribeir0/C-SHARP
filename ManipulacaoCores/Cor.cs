using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulacaoCores
{
    internal class Cor
    {
        public static void mudaCor(Control retangulo, TrackBar tbRed, TrackBar tbGreen, TrackBar tbBlue)
        {
            retangulo.BackColor = Color.FromArgb(tbRed.Value, tbGreen.Value, tbBlue.Value);    
        }
    }
}
