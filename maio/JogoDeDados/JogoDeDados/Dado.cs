using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeDados
{
    public class Dado
    {
        private Random sorteio;
        private int vitoriasJogador1;
        private int vitoriasJogador2;
        private int rodadaAtual;

        public int VitoriasJogador1 => vitoriasJogador1;
        public int VitoriasJogador2 => vitoriasJogador2;
        public int RodadaAtual => rodadaAtual;

        public Dado()
        {
            sorteio = new Random();
            Reiniciar();
        }

        public void Reiniciar()
        {
            vitoriasJogador1 = 0;
            vitoriasJogador2 = 0;
            rodadaAtual = 1;
        }

        public (int jogador1, int jogador2) Jogar()
        {
            int jogador1 = SorteiaNumero();
            int jogador2 = SorteiaNumero();

            if (jogador1 > jogador2)
                vitoriasJogador1++;
            else if (jogador2 > jogador1)
                vitoriasJogador2++;

            rodadaAtual++;
            return (jogador1, jogador2);
        }

        public bool JogoFinalizado()
        {
            return rodadaAtual > 10;
        }

        public string ResultadoFinal()
        {
            if (vitoriasJogador1 > vitoriasJogador2)
                return "Fim de jogo! Foram 10 rodadas.\n\nO Jogador 1 venceu com mais vitórias! 🎉🥳";
            else if (vitoriasJogador2 > vitoriasJogador1)
                return "Fim de jogo! Foram 10 rodadas.\n\nO Jogador 2 venceu com mais vitórias! 🎉\U0001f973";
            else
                return "Fim de jogo! Foram 10 rodadas.\n\nEmpate entre os jogadores! 🎉\U0001f973";
        }

        private int SorteiaNumero()
        {
            return sorteio.Next(1, 7);
        }


    }
}