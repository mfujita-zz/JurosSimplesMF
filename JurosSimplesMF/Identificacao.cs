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
            if (txtNome.Text.Trim() == "170000750" ||
                txtNome.Text.Trim() == "170003331" ||
                txtNome.Text.Trim() == "100014636" ||
                txtNome.Text.Trim() == "170003653" ||
                txtNome.Text.Trim() == "170000759" ||
                txtNome.Text.Trim() == "130002355" ||
                txtNome.Text.Trim() == "140003544" ||
                txtNome.Text.Trim() == "170000758" ||
                txtNome.Text.Trim() == "170000751" ||
                txtNome.Text.Trim() == "170003365" ||
                txtNome.Text.Trim() == "160001073" ||
                txtNome.Text.Trim() == "170004244" ||
                txtNome.Text.Trim() == "170005061" ||
                txtNome.Text.Trim() == "170003695" ||
                txtNome.Text.Trim() == "170000746" ||
                txtNome.Text.Trim() == "170002725" ||
                txtNome.Text.Trim() == "140000587" ||
                txtNome.Text.Trim() == "170000749" ||
                txtNome.Text.Trim() == "170000747" ||
                txtNome.Text.Trim() == "170003696")
            { 
                ra = txtNome.Text.Trim();
                Close();
            }
            else
            {
                MessageBox.Show("RA inválido.\nPor favor, verifique novamente.", "Alerta!");
                Application.Exit();
            }
        }
    }
}
