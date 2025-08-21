using System;

namespace Banco
{
    public class Lancamento
    {
        public DateTime DataHora { get; set; }
        public decimal Valor { get; set; }
        public string Pagador { get; set; }
        public string Remetente { get; set; }
        public int ContaPagador { get; set; }
        public int ContaRemetente { get; set; }
        public string Mensagem { get; set; }

        public Lancamento(string pagador, string remetente, int contaPagador, int contaRemetente, decimal valor, string mensagem)
        {
            DataHora = DateTime.Now;
            Pagador = pagador;
            Remetente = remetente;
            ContaPagador = contaPagador;
            ContaRemetente = contaRemetente;
            Valor = valor;
            Mensagem = mensagem;
        }

        public override string ToString()
        {
            string msg = string.IsNullOrWhiteSpace(Mensagem) ? "Sem mensagem" : Mensagem;
            return $"[{DataHora}] {Pagador} (Conta {ContaPagador}) transferiu {Valor:C} para {Remetente} (Conta {ContaRemetente}).\nMensagem: {msg}";
        }
    }
}