using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurosSimplesMF
{
    class CriaTexto
    {
        public int[] valores = new int[30];

        public int[] GeraValoresParaProblema(string ra)
        {
            if (ra == "17000750")
            {
                valores[0] = 35600 * 1;
                valores[1] = 58028 * 1;
            }

            return valores;
        }
    }
}
