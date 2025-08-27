using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTransferencia formTransf = new frmTransferencia();
            formTransf.ShowDialog(); // abre modal
            this.Show();
        }

        private void btnPix_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPix formPix = new frmPix();
            formPix.ShowDialog();
            this.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Deseja realmente sair do sistema?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}