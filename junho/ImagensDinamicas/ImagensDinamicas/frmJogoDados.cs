using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImagensDinamicas
{
    public partial class frmJogoDados : Form
    {
        // Variáveis de jogo
        private string nomeJogador1;
        private string nomeJogador2;

        private int contVitoria1 = 0;
        private int contVitoria2 = 0;
        private int contRodada = 1;

        private Random sorteio = new Random();

        // Timers e controle de animação
        private Timer timerDado1 = new Timer();
        private Timer timerDado2 = new Timer();

        private int contAnimacao1 = 0;
        private int contAnimacao2 = 0;

        private int resultadoDado1;
        private int resultadoDado2;

        public frmJogoDados(string jogador1, string jogador2)
        {
            InitializeComponent();
            nomeJogador1 = jogador1;
            nomeJogador2 = jogador2;

            // Eventos dos timers
            timerDado1.Interval = 200;
            timerDado1.Tick += TimerDado1_Tick;

            timerDado2.Interval = 200;
            timerDado2.Tick += TimerDado2_Tick;

            lblJogador1.Text = nomeJogador1;
            lblJogador2 .Text = nomeJogador2;
        }

        private void btJogar_Click(object sender, EventArgs e)
        {
            if (contRodada > 10)
            {
                string mensagemFinal;

                if (contVitoria1 > contVitoria2)
                {
                    mensagemFinal = $"Fim de jogo! Foram 10 rodadas.\n\n{nomeJogador1} venceu com mais vitórias! 🎉🥳";
                }
                else if (contVitoria2 > contVitoria1)
                {
                    mensagemFinal = $"Fim de jogo! Foram 10 rodadas.\n\n{nomeJogador2} venceu com mais vitórias! 🎉🥳";
                }
                else
                {
                    mensagemFinal = "Fim de jogo! Foram 10 rodadas.\n\nEmpate entre os jogadores! 🎉🥳";
                }

                MessageBox.Show(mensagemFinal, "Jogo encerrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btJogar.Enabled = false;
                return;
            }

            btJogar.Enabled = false;

            contAnimacao1 = 0;
            contAnimacao2 = 0;

            timerDado1.Start();
            timerDado2.Start();
        }

        private void TimerDado1_Tick(object sender, EventArgs e)
        {
            contAnimacao1++;

            if (contAnimacao1 < 3)
            {
                int n = sorteio.Next(1, 7);
                string caminho = Path.Combine(Application.StartupPath, "imagens", $"dado{n}.jpg");
                picDado1.Image = Image.FromFile(caminho);
            }
            else
            {
                timerDado1.Stop();
                resultadoDado1 = sorteio.Next(1, 7);
                string caminhoFinal = Path.Combine(Application.StartupPath, "imagens", $"dado{resultadoDado1}.jpg");
                picDado1.Image = Image.FromFile(caminhoFinal);
                VerificarSeAmbosTerminaram();
            }
        }

        private void TimerDado2_Tick(object sender, EventArgs e)
        {
            contAnimacao2++;

            if (contAnimacao2 < 3)
            {
                int n = sorteio.Next(1, 7);
                string caminho = Path.Combine(Application.StartupPath, "imagens", $"dado{n}.jpg");
                picDado2.Image = Image.FromFile(caminho);
            }
            else
            {
                timerDado2.Stop();
                resultadoDado2 = sorteio.Next(1, 7);
                string caminhoFinal = Path.Combine(Application.StartupPath, "imagens", $"dado{resultadoDado2}.jpg");
                picDado2.Image = Image.FromFile(caminhoFinal);
                VerificarSeAmbosTerminaram();
            }
        }

        private void VerificarSeAmbosTerminaram()
        {
            if (!timerDado1.Enabled && !timerDado2.Enabled)
            {
                VerificarGanhador(resultadoDado1, resultadoDado2);
                btJogar.Enabled = true;
            }
        }

        private void VerificarGanhador(int num1, int num2)
        {
            if (num1 > num2)
                AtualizarPlacar(1);
            else if (num2 > num1)
                AtualizarPlacar(2);
            else
                AtualizarPlacar(0);
        }

        private void AtualizarPlacar(int vencedor)
        {
            switch (vencedor)
            {
                case 1:
                    contVitoria1++;
                    lblPlacar1.Text = contVitoria1.ToString();
                    lblMostrarGanhador.Text = $"Rodada {contRodada}: {nomeJogador1} venceu !!!";
                    break;

                case 2:
                    contVitoria2++;
                    lblPlacar2.Text = contVitoria2.ToString();
                    lblMostrarGanhador.Text = $"Rodada {contRodada}: {nomeJogador2} venceu !!!";
                    break;

                case 0:
                    lblMostrarGanhador.Text = $"Rodada {contRodada}: Empate";
                    break;
            }

            contRodada++;


        }

        private void btReiniciar_Click(object sender, EventArgs e)
        {
            contVitoria1 = 0;
            contVitoria2 = 0;
            contRodada = 1;

            lblPlacar1.Text = string.Empty;
            lblPlacar2.Text = string.Empty;
            lblMostrarGanhador.Text = string.Empty;
            picDado1.Image = null;
            picDado2.Image = null;
            btJogar.Enabled = true;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmJogoDados_FormClosing(object sender, FormClosingEventArgs e)
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