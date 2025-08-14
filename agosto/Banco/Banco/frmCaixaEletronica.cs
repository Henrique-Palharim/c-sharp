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
            
        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            conta.Depositar(numValorDeposito.Value);
        }

        private void numLimiteCredito_Validating(object sender, CancelEventArgs e)
        {
            conta.LimiteCredito = numLimiteCredito.Value;
            AtualizaSaldoLimite();
        }

        private void numValorDeposito_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numValorSaque_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
