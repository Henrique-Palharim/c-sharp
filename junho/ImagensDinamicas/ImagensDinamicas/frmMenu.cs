using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static ImagensDinamicas.frmJogoDados;

/*
    Henrique Dornelas
    Inf - Noturno
    N° - 09
*/

namespace ImagensDinamicas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            // carregar imagens no menu
            string caminhoImagemDados = Path.Combine(Application.StartupPath, "imagens", "menu-dados.jpg");
            if (File.Exists(caminhoImagemDados))
                picDados.Image = Image.FromFile(caminhoImagemDados);

            string caminhoImagemFoto = Path.Combine(Application.StartupPath, "imagens", "menu-foto.jpeg");
            if (File.Exists(caminhoImagemFoto))
                picFoto.Image = Image.FromFile(caminhoImagemFoto);
        }

        private bool jogoJaExecutado = false;
        // controla a abertura do jogo, abrindo o perfil só na primeira vez
        private void AbrirJogo()
        {
            if (jogoJaExecutado)
                return;

            if (!PerfilJogadores.PerfilDefinido)
            {
                using (frmJogadores jogadores = new frmJogadores())
                {
                    var resultado = jogadores.ShowDialog();
                    if (resultado != DialogResult.OK)
                        return;
                }
            }

            if (PerfilJogadores.PerfilDefinido)
            {
                frmPlacar placar = new frmPlacar();
                frmJogoDados jogo = new frmJogoDados(placar);
                jogo.ShowDialog();
            }
        }

        private void btJogoDeDados_Click(object sender, EventArgs e)
        {
            btJogoDeDados.Enabled = false;
            AbrirJogo();
            btJogoDeDados.Enabled = true;
        }
        
        private void picDados_Click(object sender, EventArgs e)
        {
            AbrirJogo();
        }

        private void btCarregaFoto_Click(object sender, EventArgs e)
        {
            frmPlacar placar = new frmPlacar();
            placar.Show();
        }
        
        private void picFoto_Click(object sender, EventArgs e)
        {
            frmPlacar placar = new frmPlacar();
            placar.Show();
        }

        // sair do menu
        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // confirmar saída do formulário
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja Sair da Aplicação ?", "Sair", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /* --------------- Efeitos visuais nos controles --------------- */

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