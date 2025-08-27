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
    public partial class frmTransferencia : Form
    {
        Conta conta = new Conta();
        bool avisouLimite = false;

        public frmTransferencia()
        {
            InitializeComponent();
            conta.Saldo = 5000;
            conta.LimiteCredito = 500;
            AtualizaSaldoLimite();
        }

        private void AtualizaSaldoLimite()
        {
            numLimiteCredito.Value = conta.LimiteCredito;
            lblSaldo.Text = conta.Saldo.ToString("C");
            lblSaldoLimite.Text = conta.SaldoDisponivel.ToString("C");

            lblSaldo.ForeColor = (conta.Saldo < 0) ? Color.Firebrick : SystemColors.ControlText;
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            decimal saldoAntes = conta.Saldo;

            try
            {
                conta.Sacar(numValorSaque.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                return;
            }
            finally
            {
                // garante que sempre mostre o saldo atual, mesmo se der erro
                AtualizaSaldoLimite();
            }

            // aviso só quando começar a usar o limite
            if (!avisouLimite && saldoAntes >= 0 && conta.Saldo < 0)
            {
                avisouLimite = true;
                MessageBox.Show("Atenção: você está utilizando o limite de crédito!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Saque realizado com sucesso!");
            }
        }

        private void btnDepositar_Click_1(object sender, EventArgs e)
        {
            try
            {
                conta.Depositar(numValorDeposito.Value);
                // volta a avisar quando saldo >= 0
                if (conta.Saldo >= 0) avisouLimite = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                AtualizaSaldoLimite();
            }
        }

        private void numLimiteCredito_Validating(object sender, CancelEventArgs e)
        {
            conta.LimiteCredito = numLimiteCredito.Value;
            AtualizaSaldoLimite();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close(); // fecha a tela atual
        }
    }
}