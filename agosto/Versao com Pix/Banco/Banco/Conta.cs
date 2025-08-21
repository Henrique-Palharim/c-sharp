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
        // Definição dos atributos internos da Classe
        private Int32 numero;
        private decimal limiteCredito;
        private decimal saldo;
        private DateTime dataAbertura;
        private decimal contadorConta = 0;

        // Criação das propriedades da Classe referentes aos atributos internos
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
            contadorConta++;
            if (Saldo+LimiteCredito < valor)
            {
                throw new Exception("Saldo e Limtie insuficientes para realizar o saque");
            }
            else
            {
                Saldo = Saldo - valor;
            }

            if (Saldo < 0)
            {
                throw new Exception("Atenção: você está utilizando o limite de crédito da conta");
            }
        }

        public void Depositar(decimal valor)
        { 
            Saldo = Saldo + valor;
        }

    }
}
