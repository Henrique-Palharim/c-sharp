using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

/*
    Henrique Dornelas
    Inf - Noturno
    N° - 09
*/

namespace ImagensDinamicas
{
    public partial class frmPlacar : Form
    {

        public void AtualizarPlacarGeral(int vencedor)
        {
            if (vencedor == 1)
                PerfilJogadores.PlacarJogador1++;
            else if (vencedor == 2)
                PerfilJogadores.PlacarJogador2++;

            lblPlacar.Text = $"{PerfilJogadores.PlacarJogador1} x {PerfilJogadores.PlacarJogador2}";
        }

        public frmPlacar()
        {
            InitializeComponent();
            this.Load += FrmPlacar_Load;
        }

        private void FrmPlacar_Load(object sender, EventArgs e)
        {
            lblNomeJogador1.Text = PerfilJogadores.NomeJogador1;
            lblNomeJogador2.Text = PerfilJogadores.NomeJogador2;

            picFotoJogador1.Image = PerfilJogadores.FotoJogador1;
            picFotoJogador2.Image = PerfilJogadores.FotoJogador2;

            lblPlacar.Text = $"{PerfilJogadores.PlacarJogador1} x {PerfilJogadores.PlacarJogador2}";
        }

        private void btCarregarFoto1_Click(object sender, EventArgs e)
        {
            openFDFoto.Filter = "JPEG (*.jpg)|*.jpg|Bitmaps (*.bmp)|*.bmp|JFIF (*.jfif)|*.jfif";

            if (openFDFoto.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFDFoto.FileName))
                {
                    picFotoJogador1.Image = Image.FromFile(openFDFoto.FileName);
                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado.");
                }
            }
            else
            {
                picFotoJogador1.Image = null;
            }
        }

        private void btCarregarFoto2_Click(object sender, EventArgs e)
        {
            openFDFoto.Filter = "JPEG (*.jpg)|*.jpg|Bitmaps (*.bmp)|*.bmp|JFIF (*.jfif)|*.jfif";

            if (openFDFoto.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFDFoto.FileName))
                {
                    picFotoJogador2.Image = Image.FromFile(openFDFoto.FileName);
                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado.");
                }
            }
            else
            {
                picFotoJogador2.Image = null;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCarregaFoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente sair?",
                                                     "Sair",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
                e.Cancel = true;
        }

    }
}
