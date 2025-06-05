using System;
using System.Windows.Forms;

namespace ImagensDinamicas
{
    public partial class frmJogadores : Form
    {
        private string nomeJogador1;
        private string nomeJogador2;

        public frmJogadores()
        {
            InitializeComponent();
        }

        private void btContinuar_Click(object sender, EventArgs e)
        {
            if (txtJogador1.Text.Trim().Length == 0)
            {
                MessageBox.Show("O nome do Jogador 1 não deve ficar vazio",
                                "Atenção",
                                MessageBoxButtons.OK);
                return;
            }

            if (txtJogador2.Text.Trim().Length == 0)
            {
                MessageBox.Show("O nome do Jogador 2 não deve ficar vazio",
                                "Atenção",
                                MessageBoxButtons.OK);
                return;
            }

            nomeJogador1 = txtJogador1.Text.Trim();
            nomeJogador2 = txtJogador2.Text.Trim();

            this.Hide(); // Oculta o formulário de jogadores
            frmJogoDados dados = new frmJogoDados(nomeJogador1, nomeJogador2);
            dados.ShowDialog();
            this.Close(); // Fecha este formulário depois do jogo

        }
    }
}