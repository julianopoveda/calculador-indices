using System;

namespace CalculadorIndices.Domain
{
    public class Indice
    {
        public decimal Valor { get; private set; }
        public DateTime Competencia { get; private set; }
        public int Mes { get => Competencia.Month; }
        public int Ano { get => Competencia.Year; }

        public Indice(decimal valor, DateTime competencia)
        {
            Valor = valor;
            Competencia = competencia;
        }
    }
}