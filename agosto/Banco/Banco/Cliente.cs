using System;

namespace Banco
{
    internal class Cliente
    {
        // Atributos / Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }

        // Construtor
        public Cliente(int id, string nome, string cpf, string email, string telefone, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Email = email;
            Telefone = telefone;
            DataNascimento = dataNascimento;
        }

        // Métodos

        // Método para exibir os dados do cliente
        public void MostrarInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"Data de Nascimento: {DataNascimento.ToShortDateString()}");
        }

        // Exemplo: Método para validar CPF (simples)
        public bool ValidarCPF()
        {
            // Aqui pode entrar uma lógica para validar o CPF
            // Só um exemplo simplificado: CPF deve ter 11 caracteres
            return CPF != null && CPF.Length == 11;
        }
    }
}