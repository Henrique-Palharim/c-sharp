using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImagensDinamicas
{
    public partial class frmCarregaFoto : Form
    {
        public string nomeJogador1;
        public string nomeJogador2;

        public frmCarregaFoto()
        {
            InitializeComponent();
            this.Load += frmCarregaFoto_Load;

            lblPlacar.Text = $"0 x 0";
        }

        private void frmCarregaFoto_Load(object sender, EventArgs e)
        {
            
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

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNomeJogador1.Text = string.Empty;
            txtNomeJogador2.Text = string.Empty;
            picFotoJogador1.Image = null;
            picFotoJogador2.Image= null;
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

        private void btContinuar_Click(object sender, EventArgs e)
        {
            if (txtNomeJogador1.Text.Trim().Length == 0)
            {
                MessageBox.Show("O nome do Jogador 1 não deve ficar vazio",
                                "Atenção",
                                MessageBoxButtons.OK);
                return;
            }

            if (txtNomeJogador2.Text.Trim().Length == 0)
            {
                MessageBox.Show("O nome do Jogador 2 não deve ficar vazio",
                                "Atenção",
                                MessageBoxButtons.OK);
                return;
            }

            nomeJogador1 = txtNomeJogador1.Text.Trim();
            nomeJogador2 = txtNomeJogador2.Text.Trim();

            this.Hide(); // Oculta o formulário de jogadores
            frmJogoDados dados = new frmJogoDados(nomeJogador1, nomeJogador2);
            dados.ShowDialog();
            this.Close(); // Fecha este formulário depois do jogo
        }

    }
}
