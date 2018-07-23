using System;

namespace CalculadorIndices.Domain
{
    public class ValorCorrigido
    {
        public decimal Valor { get; private set; }
        public decimal IndiceAcumulado { get; private set; }

        public ValorCorrigido(decimal valor, decimal indiceAcumulado)
        {
            Valor = valor;
            IndiceAcumulado = indiceAcumulado/100;
        }
    }

    public class ValorCorrigidoPorCompetencia : ValorCorrigido
    {
        public DateTime Competencia { get; private set; }
        public ValorCorrigidoPorCompetencia(decimal valor, decimal indiceAcumulado, DateTime competencia) : base(valor, indiceAcumulado)
        {
            Competencia = competencia;
        }

    }
}