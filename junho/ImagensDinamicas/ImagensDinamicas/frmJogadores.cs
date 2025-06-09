using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

/*
    Henrique Dornelas
    Inf - Noturno
    N° - 09
*/

namespace ImagensDinamicas
{
    public partial class frmJogadores : Form
    {

        private Image fotoJogador1;
        private Image fotoJogador2;

        private OpenFileDialog openFDFoto = new OpenFileDialog();

        public frmJogadores()
        {
            InitializeComponent();

            // Inicializa os placeholders
            SetPlaceholder(txtNomeJogador1, EventArgs.Empty);
            SetPlaceholder(txtNomeJogador2, EventArgs.Empty);

            // Associa eventos
            txtNomeJogador1.Enter += RemovePlaceholder;
            txtNomeJogador1.Leave += SetPlaceholder;

            txtNomeJogador2.Enter += RemovePlaceholder;
            txtNomeJogador2.Leave += SetPlaceholder;
        }

        private void btContinuar_Click(object sender, EventArgs e)
        {
            // verificar se o texto está vazio ou é o placeholder
            if (string.IsNullOrWhiteSpace(txtNomeJogador1.Text) || txtNomeJogador1.Text == "Nome do Jogador 1" ||
                string.IsNullOrWhiteSpace(txtNomeJogador2.Text) || txtNomeJogador2.Text == "Nome do Jogador 2")
            {
                MessageBox.Show("Os nomes dos jogadores não podem estar vazios.");
                return;
            }

            PerfilJogadores.NomeJogador1 = txtNomeJogador1.Text.Trim();
            PerfilJogadores.NomeJogador2 = txtNomeJogador2.Text.Trim();

            // se imagem não foi carregada, usar a imagem padrão
            if (picFotoJogador1.Image == null)
            {
                PerfilJogadores.FotoJogador1 = ObterImagemPadrao();
            }
            else
            {
                PerfilJogadores.FotoJogador1 = picFotoJogador1.Image;
            }

            if (picFotoJogador2.Image == null)
            {
                PerfilJogadores.FotoJogador2 = ObterImagemPadrao();
            }
            else
            {
                PerfilJogadores.FotoJogador2 = picFotoJogador2.Image;
            }

            PerfilJogadores.PerfilDefinido = true;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNomeJogador1.Text = string.Empty;
            txtNomeJogador2.Text = string.Empty;
            picFotoJogador1.Image = null;
            picFotoJogador2.Image = null;
        }

        /* ------------------------------------------------------------------- */

        // imagens dos Jogadores

        private void btCarregarFoto1_Click(object sender, EventArgs e)
        {
            openFDFoto.Filter = "JPEG (*.jpg)|*.jpg|Bitmaps (*.bmp)|*.bmp|JFIF (*.jfif)|*.jfif";

            if (openFDFoto.ShowDialog() == DialogResult.OK && File.Exists(openFDFoto.FileName))
            {
                fotoJogador1 = Image.FromFile(openFDFoto.FileName);
                picFotoJogador1.Image = fotoJogador1;
            }
            else
            {
                fotoJogador1 = ObterImagemPadrao();
                picFotoJogador1.Image = fotoJogador1;
            }
        }

        private void btCarregarFoto2_Click(object sender, EventArgs e)
        {
            openFDFoto.Filter = "JPEG (*.jpg)|*.jpg|Bitmaps (*.bmp)|*.bmp|JFIF (*.jfif)|*.jfif";

            if (openFDFoto.ShowDialog() == DialogResult.OK && File.Exists(openFDFoto.FileName))
            {
                fotoJogador2 = Image.FromFile(openFDFoto.FileName);
                picFotoJogador2.Image = fotoJogador2;
            }
            else
            {
                fotoJogador2 = ObterImagemPadrao();
                picFotoJogador2.Image = fotoJogador2;
            }
        }

        private Image ObterImagemPadrao()
        {
            string caminhoImagemPadrao = Path.Combine(Application.StartupPath, "imagens", "user.png");
            if (File.Exists(caminhoImagemPadrao))
            {
                return Image.FromFile(caminhoImagemPadrao);
            }
            else
            {
                MessageBox.Show("Imagem padrão 'user.png' não encontrada na pasta imagens.");
                return null;
            }
        }

        /* ------------------------------------------------------------------- */
        // Placeholder

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null && string.IsNullOrWhiteSpace(tb.Text))
            {
                if (tb == txtNomeJogador1)
                    tb.Text = "Nome do Jogador 1";
                else if (tb == txtNomeJogador2)
                    tb.Text = "Nome do Jogador 2";

                tb.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                if (tb == txtNomeJogador1 && tb.Text == "Nome do Jogador 1")
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                }
                else if (tb == txtNomeJogador2 && tb.Text == "Nome do Jogador 2")
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                }
            }
        }

    }
}