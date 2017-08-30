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
            if (ra == "170000750")
            {
                valores[0] = 35600 * 1;
                valores[1] = 58028 * 1;
            }

            else if (ra == "170003331")
            {
                valores[0] = 35600 * 2;
                valores[1] = 58028 * 2;
            }

            else if (ra == "100014636")
            {
                valores[0] = 35600 * 3;
                valores[1] = 58028 * 3;
            }

            else if (ra == "170003653")
            {
                valores[0] = 35600 * 4;
                valores[1] = 58028 * 4;
            }

            else if (ra == "170000759")
            {
                valores[0] = 35600 * 5;
                valores[1] = 58028 * 5;
            }

            else if (ra == "130002355")
            {
                valores[0] = 35600 * 6;
                valores[1] = 58028 * 6;
            }

            else if (ra == "140003544")
            {
                valores[0] = 35600 * 7;
                valores[1] = 58028 * 7;
            }

            else if (ra == "170000758")
            {
                valores[0] = 35600 * 8;
                valores[1] = 58028 * 8;
            }

            else if (ra == "170000751")
            {
                valores[0] = 35600 * 9;
                valores[1] = 58028 * 9;
            }

            else if (ra == "170003365")
            {
                valores[0] = 35600 * 10;
                valores[1] = 58028 * 10;
            }

            else if (ra == "160001073")
            {
                valores[0] = 35600 * 11;
                valores[1] = 58028 * 11;
            }

            else if (ra == "170004244")
            {
                valores[0] = 35600 * 12;
                valores[1] = 58028 * 12;
            }

            else if (ra == "170005061")
            {
                valores[0] = 35600 * 13;
                valores[1] = 58028 * 13;
            }

            else if (ra == "170003695")
            {
                valores[0] = 35600 * 14;
                valores[1] = 58028 * 14;
            }

            else if (ra == "170000746")
            {
                valores[0] = 35600 * 15;
                valores[1] = 58028 * 15;
            }

            else if (ra == "170002725")
            {
                valores[0] = 35600 * 16;
                valores[1] = 58028 * 16;
            }

            else if (ra == "140000587")
            {
                valores[0] = 35600 * 17;
                valores[1] = 58028 * 17;
            }

            else if (ra == "170000749")
            {
                valores[0] = 35600 * 18;
                valores[1] = 58028 * 18;
            }

            else if (ra == "170000747")
            {
                valores[0] = 35600 * 19;
                valores[1] = 58028 * 19;
            }

            else if (ra == "170003696")
            {
                valores[0] = 35600 * 20;
                valores[1] = 58028 * 20;
            }

            return valores;
        }
    }
}
