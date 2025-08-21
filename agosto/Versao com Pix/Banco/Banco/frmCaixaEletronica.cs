using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using Banco;

namespace Banco
{
    public partial class frmCaixaEletronica : Form
    {
        Conta conta = new Conta();

        // Lista para armazenar todos os lançamentos (transações Pix)
        List<Lancamento> historicoLancamentos = new List<Lancamento>();

        public frmCaixaEletronica()
        {
            InitializeComponent();

            // Inicialização da conta
            conta.Saldo = 5000;
            conta.LimiteCredito = 500;
            AtualizaSaldoLimite();
        }

        /* ---------------- TRANSFERÊNCIA ---------------- */

        private void AtualizaSaldoLimite()
        {
            numLimiteCredito.Value = conta.LimiteCredito;
            lblSaldo.Text = conta.Saldo.ToString("C");
            lblSaldoLimite.Text = (conta.Saldo + conta.LimiteCredito).ToString("C");
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            try
            {
                conta.Sacar(numValorSaque.Value);
                AtualizaSaldoLimite();
                MessageBox.Show("Saque realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar o saque!" +
                                "\n\nMais detalhes: " + ex.Message,
                                "Erro ao sacar",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                AtualizaSaldoLimite();
            }
        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            conta.Depositar(numValorDeposito.Value);
            AtualizaSaldoLimite();
        }

        private void numLimiteCredito_Validating(object sender, CancelEventArgs e)
        {
            conta.LimiteCredito = numLimiteCredito.Value;
            AtualizaSaldoLimite();
        }

        /* ---------------- PIX ---------------- */

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            // Validação dos campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtPagador.Text))
            {
                MessageBox.Show("O campo Pagador não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPagador.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRemetente.Text))
            {
                MessageBox.Show("O campo Remetente não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRemetente.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContaPagador.Text))
            {
                MessageBox.Show("O campo Conta Pagador não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContaPagador.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContaRemetente.Text))
            {
                MessageBox.Show("O campo Conta Remetente não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContaRemetente.Focus();
                return;
            }

            if (numValorTransferencia.Value <= 0)
            {
                MessageBox.Show("O valor da transferência deve ser maior que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numValorTransferencia.Focus();
                return;
            }

            try
            {
                // Captura dos dados dos TextBoxes
                string pagador = txtPagador.Text.Trim();
                string remetente = txtRemetente.Text.Trim();
                int contaPagador = int.Parse(txtContaPagador.Text);
                int contaRemetente = int.Parse(txtContaRemetente.Text);
                decimal valor = numValorTransferencia.Value;
                string mensagem = string.IsNullOrWhiteSpace(txtMensagem.Text) ? "Sem mensagem" : txtMensagem.Text.Trim();

                // Realiza o saque da conta (remetente)
                conta.Sacar(valor);

                // Deposita na mesma conta (simples, pois só existe uma conta nesse exemplo)
                conta.Depositar(valor);

                // Cria um novo lançamento com os dados da transferência Pix
                Lancamento lancamento = new Lancamento(pagador, remetente, contaPagador, contaRemetente, valor, mensagem);

                // Adiciona o lançamento ao histórico em memória
                historicoLancamentos.Add(lancamento);

                AtualizaSaldoLimite();

                MessageBox.Show("Transferência realizada com sucesso!\n\n" + lancamento.ToString(), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar campos após transferência
                LimparCamposPix();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na transferência:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCamposPix()
        {
            txtPagador.Clear();
            txtRemetente.Clear();
            txtContaPagador.Clear();
            txtContaRemetente.Clear();
            numValorTransferencia.Value = 0;
            txtMensagem.Clear();
        }

        /* ---------------- EXTRATO PIX ---------------- */

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            if (historicoLancamentos.Count == 0)
            {
                MessageBox.Show("Nenhuma operação de Pix realizada ainda.", "Histórico Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder sb = new StringBuilder();

            foreach (var lanc in historicoLancamentos)
            {
                sb.AppendLine(lanc.ToString());
                sb.AppendLine(new string('-', 50)); // Linha separadora
            }

            MessageBox.Show(sb.ToString(), "Extrato de Pix", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* ---------------- VALIDAÇÃO DOS TEXTBOX ---------------- */

        private void SomenteLetras(KeyPressEventArgs e)
        {
            // Permite apenas letras, espaços e backspace
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtPagador_KeyPress(object sender, KeyPressEventArgs e)
        {
            SomenteLetras(e);
        }

        private void txtRemetente_KeyPress(object sender, KeyPressEventArgs e)
        {
            SomenteLetras(e);
        }

        private void txtContaPagador_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContaRemetente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmCaixaEletronica_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true; // Cancela o fechamento do formulário
            }
        }
    }
}