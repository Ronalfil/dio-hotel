using System;
using System.Collections.Generic;
using DIO.Models;

namespace DIO
{
    class Program
    {
        static void Main(string[] arg)
        {
            // Cria uma suíte
            Suite suite = new Suite("Premium", 2, 150M);

            // Cria uma reserva
            Reserva reserva = new Reserva(5);
            reserva.CadastrarSuite(suite);

            // Adiciona dois hóspedes
            List<Pessoa> hospedes = new List<Pessoa>
            {
                new Pessoa("Hóspede 1"),
                new Pessoa("Hóspede 2"),
                
            };

            reserva.CadastrarHospedes(hospedes);

            // Exibe a quantidade de hóspedes
            Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");

            // Calcula e exibe o valor da diária
            Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria():C}");
        }
    }
}