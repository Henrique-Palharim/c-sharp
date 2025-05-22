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

namespace JogoDeDados
{
    public partial class frmJogoDados : Form
    {
        private Dado jogo;

        public frmJogoDados()
        {
            InitializeComponent();
            jogo = new Dado();
        }

        private void btReiniciar_Click_1(object sender, EventArgs e)
        {
            jogo.Reiniciar();

            lblPlacar1.Text = string.Empty;
            lblPlacar2.Text = string.Empty;
            lblMostrarGanhador.Text = string.Empty;
            picDado1.Image = null;
            picDado2.Image = null;
            btJogar.Enabled = true;
        }

        private void btSair_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair ?", "Sair",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btJogar_Click(object sender, EventArgs e)
        {
            if (jogo.JogoFinalizado())
            {
                MessageBox.Show(jogo.ResultadoFinal(), "Jogo encerrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btJogar.Enabled = false;
                return;
            }

            var (num1, num2) = jogo.Jogar();

            AtualizaImagem(picDado1, num1);
            AtualizaImagem(picDado2, num2);

            AtualizarPlacar(num1, num2);
        }

        private void AtualizaImagem(PictureBox pic, int numero)
        {
            string caminhoImagem = Path.Combine(Application.StartupPath, "imagens", $"dado{numero}.jpg");
            pic.Image = Image.FromFile(caminhoImagem);
        }

        private void AtualizarPlacar(int num1, int num2)
        {
            lblPlacar1.Text = jogo.VitoriasJogador1.ToString();
            lblPlacar2.Text = jogo.VitoriasJogador2.ToString();

            if (num1 > num2)
                lblMostrarGanhador.Text = $"Rodada {jogo.RodadaAtual - 1}: Jogador 1 venceu !!!";
            else if (num2 > num1)
                lblMostrarGanhador.Text = $"Rodada {jogo.RodadaAtual - 1}: Jogador 2 venceu !!!";
            else
                lblMostrarGanhador.Text = $"Rodada {jogo.RodadaAtual - 1}: Empate";
        }
    }
}