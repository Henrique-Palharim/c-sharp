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
    public partial class frmPix : Form
    {
        Conta conta = new Conta();
        List<Lancamento> historicoLancamentos = new List<Lancamento>();

        public frmPix()
        {
            InitializeComponent();
            conta.Saldo = 5000;
            conta.LimiteCredito = 500;
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            // Validação básica dos campos
            if (string.IsNullOrWhiteSpace(txtPagador.Text) ||
                string.IsNullOrWhiteSpace(txtRemetente.Text) ||
                string.IsNullOrWhiteSpace(txtContaPagador.Text) ||
                string.IsNullOrWhiteSpace(txtContaRemetente.Text) ||
                numValorTransferencia.Value <= 0)
            {
                MessageBox.Show("Preencha todos os campos corretamente e informe um valor maior que zero.");
                return;
            }

            try
            {
                // Captura dos dados
                string pagador = txtPagador.Text.Trim();
                string remetente = txtRemetente.Text.Trim();
                int contaPagador = int.Parse(txtContaPagador.Text);
                int contaRemetente = int.Parse(txtContaRemetente.Text);
                decimal valor = numValorTransferencia.Value;
                string mensagem = string.IsNullOrWhiteSpace(txtMensagem.Text) ? "Sem mensagem" : txtMensagem.Text.Trim();

                // Apenas registra o lançamento, sem mexer no saldo
                Lancamento lancamento = new Lancamento(pagador, remetente, contaPagador, contaRemetente, valor, mensagem);
                historicoLancamentos.Add(lancamento);

                MessageBox.Show("Pix realizado com sucesso!\n" + lancamento.ToString());

                // Se quiser limpar campos após transferência
                //txtPagador.Clear();
                //txtRemetente.Clear();
                //txtContaPagador.Clear();
                //txtContaRemetente.Clear();
                txtMensagem.Clear();
                numValorTransferencia.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            if (historicoLancamentos.Count == 0)
            {
                MessageBox.Show("Nenhum Pix realizado.");
                return;
            }

            StringBuilder sb = new StringBuilder();
            foreach (var lanc in historicoLancamentos)
            {
                sb.AppendLine(lanc.ToString());
                sb.AppendLine(new string('-', 50));
            }

            MessageBox.Show(sb.ToString(), "Extrato Pix");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}