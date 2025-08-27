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
        bool avisouLimite = false; // controla aviso único

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

            // Opcional: feedback visual
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
                // garante que a UI sempre reflita o estado atual, mesmo se der erro
                AtualizaSaldoLimite();
            }

            // Aviso só quando CRUZAR para o limite (de não-negativo -> negativo)
            if (!avisouLimite && saldoAntes >= 0 && conta.Saldo < 0)
            {
                avisouLimite = true;
                // Se não quiser popup, remova a MessageBox e deixe só a cor da label
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
                // Se voltou para saldo >= 0, libera avisar de novo no futuro
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
            this.Close(); // Fecha a tela atual
        }
    }
}