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

namespace ImagensDinamicas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            string caminhoImagemDados = Path.Combine(Application.StartupPath, "imagens", $"menu-dados.jpg");
            picDados.Image = Image.FromFile(caminhoImagemDados);

            string caminhoImagemFoto = Path.Combine(Application.StartupPath, "imagens", $"menu-foto.jpeg");
            picFoto.Image = Image.FromFile(caminhoImagemFoto);
        }

        private void btJogoDeDados_Click(object sender, EventArgs e)
        {
            frmCarregaFoto perfil = new frmCarregaFoto();
            perfil.Show();
        }
        private void picDados_Click(object sender, EventArgs e)
        {
            frmCarregaFoto perfil = new frmCarregaFoto();
            perfil.Show();
        }

        private void btCarregaFoto_Click(object sender, EventArgs e)
        {
            frmCarregaFoto foto = new frmCarregaFoto();
            foto.Show();
        }
        private void picFoto_Click(object sender, EventArgs e)
        {
            frmCarregaFoto foto = new frmCarregaFoto();
            foto.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Deseja Sair da Aplicação ?",
                                       "Sair",
                                       MessageBoxButtons.YesNo);

            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        /* --------------- Efeitos --------------- */

        private void picDados_MouseEnter(object sender, EventArgs e)
        {
            picDados.Cursor = Cursors.Hand;
        }
        private void picDados_MouseLeave(object sender, EventArgs e)
        {
            picDados.Cursor = Cursors.Default;
        }

        private void picFoto_MouseEnter(object sender, EventArgs e)
        {
            picFoto.Cursor = Cursors.Hand;
        }
        private void picFoto_MouseLeave(object sender, EventArgs e)
        {
            picFoto.Cursor = Cursors.Default;
        }
    }
}
