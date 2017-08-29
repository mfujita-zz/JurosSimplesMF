using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JurosSimplesMF
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Identificacao id = new Identificacao();
            id.ShowDialog();

            if (Identificacao.ra == "17000750")
            {
                Text = "Amanda";
                Font fonte = new Font("Microsoft Sans Serif", 12f);
                CriaTexto ct = new CriaTexto();
                int[] val = ct.GeraValoresParaProblema(Identificacao.ra);
                lblTexto.Text = "A aplicação de $ "+ val[0].ToString("0,00") +",00 gerou um montante de $ " + val[1].ToString("0,00") + ",00 no final de 9 meses.\nCalcular a taxa anual.";
                Size tamanho = TextRenderer.MeasureText(lblTexto.Text, fonte);
                Width = Convert.ToInt32(tamanho.Width * 1.1);
                btnSalvar.Location = new Point(Convert.ToInt32(tamanho.Width) - btnSalvar.Width, txtResposta.Top);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
