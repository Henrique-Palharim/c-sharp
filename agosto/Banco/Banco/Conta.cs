using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public class Conta
    {
        // Definição dos atributos da Classe
        private Int32 numero;
        private decimal limiteCredito;
        private decimal saldo;
        private DateTime dataAbertura;
        private decimal contadorConta = 0;

        public Int32 Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public decimal LimiteCredito
        {
            get { return limiteCredito; }
            set { limiteCredito = value; }
        }

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public DateTime DataAbertura
        {
            get { return dataAbertura; }
            set {  dataAbertura = value; }
        }

        // Método construtor da classe Conta    

        public Conta()
        {
            Numero = 0;
            LimiteCredito = 0;
            Saldo = 0;
            DataAbertura = DateTime.Now;
        }

        // Criação dos métodos da Classe
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
                throw new Exception("O valor do saque deve ser maior que zero.");

            if (Saldo + LimiteCredito < valor)
            {
                throw new Exception("Saldo e limite insuficientes para realizar o saque.");
            }

            Saldo -= valor;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
                throw new Exception("O valor do depósito deve ser maior que zero.");

            Saldo += valor;
        }

    }
}
