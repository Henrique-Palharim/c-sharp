using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImagensDinamicas
{
    internal class PerfilJogadores
    {
        public static bool PerfilDefinido { get; set; } = false;

        public static string NomeJogador1 { get; set; } = "";
        public static string NomeJogador2 { get; set; } = "";

        public static Image FotoJogador1 { get; set; } = null;
        public static Image FotoJogador2 { get; set; } = null;

        public static int PlacarJogador1 { get; set; } = 0;
        public static int PlacarJogador2 { get; set; } = 0;
    }
}
