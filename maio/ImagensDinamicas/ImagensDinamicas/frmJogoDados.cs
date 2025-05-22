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
using System.Xml.Linq;

namespace ImagensDinamicas
{
    public partial class frmJogoDados : Form
    {
        /* --------------- VARIÁVEIS GLOBAIS --------------- */

        Random sorteio = new Random();
        int contVitoria1 = 0, contVitoria2 = 0, contRodada = 1;

        /* --------------- COMPONENTES --------------- */

        public frmJogoDados()
        {
            InitializeComponent();
        }

        private void btReiniciar_Click(object sender, EventArgs e)
        {
            // reinicia as variáveis
            contVitoria1 = 0;
            contVitoria2 = 0;
            contRodada = 1;

            // limpa os campos de texto e as imagens
            lblPlacar1.Text = string.Empty;
            lblPlacar2.Text = string.Empty;
            lblMostrarGanhador.Text = string.Empty;
            picDado1.Image = null;
            picDado2.Image = null;

            // garente que o botão de jogar fique ativo
            btJogar.Enabled = true;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente sair ?",
                                                     "Sair",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btJogar_Click(object sender, EventArgs e)
        {
            if (contRodada > 10)
            {
                string mensagemFinal;

                if (contVitoria1 > contVitoria2)
                {
                    mensagemFinal = "Fim de jogo! Foram 10 rodadas.\n\nO Jogador 1 venceu com mais vitórias! 🎉🥳";
                }
                else if (contVitoria2 > contVitoria1)
                {
                    mensagemFinal = "Fim de jogo! Foram 10 rodadas.\n\nO Jogador 2 venceu com mais vitórias! 🎉\U0001f973";
                }
                else
                {
                    mensagemFinal = "Fim de jogo! Foram 10 rodadas.\n\nEmpate entre os jogadores! 🎉\U0001f973";
                }

                MessageBox.Show(mensagemFinal,
                                "Jogo encerrado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                btJogar.Enabled = false;
                return;
            }

            int numSorteado1 = SortearDado(picDado1);
            int numSorteado2 = SortearDado(picDado2);

            VerificarGanhador(numSorteado1, numSorteado2);
        }

        /* --------------- FUNÇÕES --------------- */

        // sorteia o número e carrega a imagem no PictureBox correspondente
        private int SortearDado(PictureBox picDado)
        {
            int numero = sorteio.Next(1, 7); // 1 a 6
            string caminhoImagem = Path.Combine(Application.StartupPath, "imagens", $"dado{numero}.jpg"); // funciona se o arquivo estiver junto do projeto

            picDado.Image = Image.FromFile(caminhoImagem);

            return numero;
        }

        //vVerifica quem venceu e chama função para atualizar placar e mensagem
        private void VerificarGanhador(int numSorteado1, int numSorteado2)
        {
            if (numSorteado1 > numSorteado2)
                AtualizarPlacar(1);
            else if (numSorteado2 > numSorteado1)
                AtualizarPlacar(2);
            else
                AtualizarPlacar(0); // empate
        }

        // atualiza placar, mensagem e rodada
        private void AtualizarPlacar(int jogador)
        {
            switch (jogador)
            {
                case 1:
                    contVitoria1++;
                    lblPlacar1.Text = contVitoria1.ToString();
                    lblMostrarGanhador.Text = $"Rodada {contRodada}: Jogador 1 venceu !!!";
                    break;

                case 2:
                    contVitoria2++;
                    lblPlacar2.Text = contVitoria2.ToString();
                    lblMostrarGanhador.Text = $"Rodada {contRodada}: Jogador 2 venceu !!!";
                    break;

                case 0:
                    lblMostrarGanhador.Text = $"Rodada {contRodada}: Empate";
                    break;
            }

            contRodada++;
        }


    }
}