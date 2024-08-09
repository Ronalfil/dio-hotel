using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Models
{

    public class Suite
    {
        public string TipoSuite { get; set; } = string.Empty; // Inicialização para evitar o aviso
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public Suite() { }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }

}