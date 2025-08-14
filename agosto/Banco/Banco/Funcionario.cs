using System;

namespace Banco
{
    internal class Funcionario
    {
        // Atributos / Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        // Construtor
        public Funcionario(int id, string nome, string cpf, string cargo, decimal salario, DateTime dataAdmissao)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Cargo = cargo;
            Salario = salario;
            DataAdmissao = dataAdmissao;
        }

        // Métodos

        public void MostrarInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário: {Salario:C}");
            Console.WriteLine($"Data de Admissão: {DataAdmissao.ToShortDateString()}");
        }

        public void AumentarSalario(decimal percentual)
        {
            if (percentual > 0)
            {
                Salario += Salario * percentual / 100;
                Console.WriteLine($"Salário aumentado em {percentual}%.");
            }
            else
            {
                Console.WriteLine("Percentual inválido.");
            }
        }

        public bool VerificarAniversario(DateTime dataAtual)
        {
            // Exemplo: se o aniversário do funcionário é no mês atual
            return dataAtual.Month == DataAdmissao.Month && dataAtual.Day == DataAdmissao.Day;
        }
    }
}