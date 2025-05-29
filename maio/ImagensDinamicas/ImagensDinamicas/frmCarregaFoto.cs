using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagensDinamicas
{
    public partial class frmCarregaFoto : Form
    {
        public frmCarregaFoto()
        {
            InitializeComponent();
        }

        private void btCarregarFoto_Click(object sender, EventArgs e)
        {
            openFDFoto.Filter = "JPEG (*jpg)|*.jpg|" + "Bitmaps (*.bmp)|*.bmp|" + "JFIF (*.jfif)|*.jfif";
            if (openFDFoto.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(openFDFoto.FileName);
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
            DialogResult resultado = MessageBox.Show("Deseja realmente sair ?",
                                                     "Sair",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
