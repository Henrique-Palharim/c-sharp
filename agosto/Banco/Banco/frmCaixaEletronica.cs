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
    public partial class frmCaixaEletronica : Form
    {
        Conta conta = new Conta();
        public frmCaixaEletronica()
        {
            InitializeComponent();
            conta.Saldo = 5000; // Inicializando o saldo da conta
            conta.LimiteCredito = 500;
            AtualizaSaldoLimite();
        }

        private void AtualizaSaldoLimite()
        {
            numLimiteCredito.Value = conta.LimiteCredito;
            lblSaldo.Text = conta.Saldo.ToString("C"); // Exibindo o saldo formatado
            lblSaldoLimite.Text = (conta.Saldo + conta.LimiteCredito).ToString("C");
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            decimal valor = numValorSaque.Value;

            if (valor <= 0)
            {
                MessageBox.Show("Digite um valor maior que zero para saque.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conta.Sacar(valor);
                AtualizaSaldoLimite();

                if (conta.Saldo < 0)
                {
                    MessageBox.Show("Saque realizado, mas você está usando seu limite de crédito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Saque realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar o saque!\n\nDetalhes: " + ex.Message,
                                "Erro ao sacar",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            decimal valor = numValorDeposito.Value;

            if (valor <= 0)
            {
                MessageBox.Show("Digite um valor maior que zero para depósito.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conta.Depositar(valor);
            AtualizaSaldoLimite();
            MessageBox.Show("Depósito realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void numLimiteCredito_Validating(object sender, CancelEventArgs e)
        {
            conta.LimiteCredito = numLimiteCredito.Value;
            AtualizaSaldoLimite();
        }

    }
}