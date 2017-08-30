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
    public partial class Identificacao : Form
    {
        public static string ra;
        public Identificacao()
        {
            InitializeComponent();
        }

        private void Identificacao_Load(object sender, EventArgs e)
        {
            lblRA.Text = "Por favor, coloque seu RA (apenas números).";
            txtNome.Select();
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            { 
                ra = txtNome.Text.Trim();
                Close();
            }
            else
            {
                MessageBox.Show("Por favor, preencha seu nome.", "Alerta!");
            }
        }
    }
}
