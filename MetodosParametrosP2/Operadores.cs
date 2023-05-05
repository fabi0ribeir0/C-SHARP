using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosParametrosP2
{
    internal class Operadores
    {
        int res = 0;
        public int solucao(int v1, int v2, string op)
        {
            switch (op)
            {
                case "adicao":
                    res = v1 + v2;
                    break;
                case "subtracao":
                    res = v1 - v2;
                    break;
                case "multiplicacao":
                    res = v1* v2;
                    break;
                case "divisao":
                    res = v1 / v2;
                    break;
                default:
                    res = 0;
                    break;
            }

            return res;
        }
    }
}
