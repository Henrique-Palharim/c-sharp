using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImagensDinamicas
{
    public partial class frmCarregaFoto : Form
    {
        public frmCarregaFoto()
        {
            InitializeComponent();
            this.Load += frmCarregaFoto_Load;
        }

        private void frmCarregaFoto_Load(object sender, EventArgs e)
        {
            // Preenche os campos com informações do sistema
            txtNome.Text = Environment.UserName;
            txtComputador.Text = Environment.MachineName;
        }

        private void btCarregarFoto_Click(object sender, EventArgs e)
        {
            openFDFoto.Filter = "JPEG (*.jpg)|*.jpg|Bitmaps (*.bmp)|*.bmp|JFIF (*.jfif)|*.jfif";

            if (openFDFoto.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFDFoto.FileName))
                {
                    picFoto.Image = Image.FromFile(openFDFoto.FileName);
                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado.");
                }
            }
            else
            {
                picFoto.Image = null;
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            picFoto.Image = null;
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
