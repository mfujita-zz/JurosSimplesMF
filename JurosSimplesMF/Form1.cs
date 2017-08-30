using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JurosSimplesMF
{
    public partial class Principal : Form
    {
        string nomeAluno="";
        string enunciado = "";

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Identificacao id = new Identificacao();
            id.ShowDialog();

            if (Identificacao.ra == "170000750")
            {
                Text = "Amanda";
                //nomeAluno = Text;
                TextoDoProblema();
            }

            if (Identificacao.ra == "170003331")
            {
                Text = "Andrea Gati";
                //nomeAluno = Text;
                TextoDoProblema();
            }

            if (Identificacao.ra == "100014636")
            {
                Text = "Andrea Leoni";
                //nomeAluno = Text;
                TextoDoProblema();
            }

            if (Identificacao.ra == "170003653")
            {
                Text = "Andrew";
                //nomeAluno = Text;
                TextoDoProblema();

            }

            if (Identificacao.ra == "170000759")
            {
                Text = "Andreza";
                //nomeAluno = Text;
                TextoDoProblema();
            }

            if (Identificacao.ra == "130002355")
            {
                Text = "Bruna";
                //nomeAluno = Text;
                TextoDoProblema();
            }

            if (Identificacao.ra == "140003544")
            {
                Text = "Caroline";
                //nomeAluno = Text;
                TextoDoProblema();
            }

            if (Identificacao.ra == "170000758")
            {
                Text = "Eduardo de Lima";
                //nomeAluno = Text;
                TextoDoProblema();
            }

            if (Identificacao.ra == "170000751")
            {
                Text = "Eduardo de Oliveira";
                //nomeAluno = Text;
                TextoDoProblema();
            }

            if (Identificacao.ra == "170003365")
            {
                Text = "Fernanda";
                //nomeAluno = Text;
                TextoDoProblema();
            }

            if (Identificacao.ra == "160001073")
            {
                Text = "Gabriel";
                //nomeAluno = Text;
                TextoDoProblema();
            }

            if (Identificacao.ra == "170004244")
            {
                Text = "Giovane";
                //nomeAluno = Text;
                TextoDoProblema();
            }

            if (Identificacao.ra == "170005061")
            {
                Text = "Larissa";
                //nomeAluno = Text;
                TextoDoProblema();
            }

            if (Identificacao.ra == "170003695")
            {
                Text = "Lucas";
                //nomeAluno = Text;
                TextoDoProblema();
            }

            if (Identificacao.ra == "170000746")
            {
                Text = "Nathalia";
                //nomeAluno = Text;
                TextoDoProblema();
            }

            if (Identificacao.ra == "170002725")
            {
                Text = "Paloma";
                //nomeAluno = Text;
                TextoDoProblema();
            }

            if (Identificacao.ra == "140000587")
            {
                Text = "Patricia";
                //nomeAluno = Text;
                TextoDoProblema();
            }

            if (Identificacao.ra == "170000749")
            {
                Text = "Paula";
                //nomeAluno = Text;
                TextoDoProblema();
            }

            if (Identificacao.ra == "170000747")
            {
                Text = "Thaís";
                //nomeAluno = Text;
                TextoDoProblema();
            }

            if (Identificacao.ra == "170003696")
            {
                Text = "Victória";

                TextoDoProblema();
            }
        }

        private void TextoDoProblema()
        {
            nomeAluno = Text;
            Font fonte = new Font("Microsoft Sans Serif", 12f);
            CriaTexto ct = new CriaTexto();
            int[] val = ct.GeraValoresParaProblema(Identificacao.ra);
            lblTexto.Text = "A aplicação de $ " + val[0].ToString("0,00") + ",00 gerou um montante de $ " + val[1].ToString("0,00") + ",00 no final de 9 meses.\nCalcular a taxa anual.\nObservação: A taxa de juros é composta de um valor seguido do símbolo \"%\" e um período (ao dia, ao mês, ao bimestre, etc.)";
            Size tamanho = TextRenderer.MeasureText(lblTexto.Text, fonte);
            Width = Convert.ToInt32(tamanho.Width * 1.1);
            btnSalvar.Location = new Point(Convert.ToInt32(tamanho.Width) - btnSalvar.Width, txtResposta.Top);
            enunciado = lblTexto.Text.Replace("\n", "<br>&nbsp&nbsp");
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtResposta.Text != "")
            { 
                FileStream fs = new FileStream(nomeAluno + ".html", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine("<html> ");
                sw.WriteLine("	<head>");
                sw.WriteLine("		<title>Juros simples</title>");
                sw.WriteLine("		<meta charset=\"UTF-8\" />");
                sw.WriteLine("		<style>");
                sw.WriteLine("		body {");
                sw.WriteLine("			margin: 0;");
                sw.WriteLine("		}");
                sw.WriteLine("		.texto { ");
                sw.WriteLine("			background-color: #101030;");
                sw.WriteLine("			height: 100px;   ");
                sw.WriteLine("		}");
                sw.WriteLine("		.resposta {");
                sw.WriteLine("			height: 300px;");
                sw.WriteLine("			font-size: 30px;");
                sw.WriteLine("		}");
                sw.WriteLine("		p { color: yellow; }");
                sw.WriteLine("		</style>");
                sw.WriteLine("	</head>");
                sw.WriteLine("	<body>");
                sw.WriteLine("		<strong>"+nomeAluno+"</strong>");
                sw.WriteLine("		<h1><div align=\"center\">Juros simples</div></h1>");
                sw.WriteLine("		<div class=\"texto\">");
                sw.WriteLine("			<p>&nbsp&nbsp" + enunciado+"</p>");
                sw.WriteLine("		</div>");
                sw.WriteLine("		<div class=\"resposta\">");
                sw.WriteLine(txtResposta.Text);
                sw.WriteLine("		</div>");
                sw.WriteLine("		<h2><div align=\"right\">" + DateTime.Now.ToShortDateString() + " - " +  DateTime.Now.ToShortTimeString() + "</div></h2>");
                sw.WriteLine("<br>");
                sw.WriteLine("<strong>&copy; Professor Murilo Fujita</strong>");
                sw.WriteLine("	</body>");
                sw.WriteLine("</html>");
                sw.Close();
                MessageBox.Show("Localize o arquivo " + Directory.GetCurrentDirectory() + "\\" + nomeAluno + ".html e envie através do moodle.");
            }
            else
            {
                MessageBox.Show("Preencha a taxa anual conforme pede o problema.");
            }
        }
    }
}
