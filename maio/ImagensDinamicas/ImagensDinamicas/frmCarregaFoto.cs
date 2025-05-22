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
    }
}
