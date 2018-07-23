using System;
using System.Linq;
using System.Collections.Generic;

namespace CalculadorIndices.IndicesCorrecao
{
    public class Utils
    {
        /// <summary>
        /// Calcula quantos dias faltam para terminar o mês da dataInicial informada
        /// e qual a fração esta diferença representa
        /// </summary>
        /// <param name="dataInicial">A data de origem da pro-rata</param>
        /// <returns>A fração de dias que faltam para o fim do mês</returns>
        public static decimal CalcularProRata(DateTime dataInicial)
        {
            int DiasDoMes = dataInicial.AddMonths(1).AddDays(-dataInicial.Day - 1).Day;
            return (DiasDoMes - dataInicial.Day) / DiasDoMes;
        }

        /// <summary>
        /// Efetua o cálculo de juros composta
        /// </summary>
        /// <param name="indices">Lista de índices que devem ser calculados</param>
        /// <returns>O acumulado da lista de indices</returns>
        public static decimal CalcularJurosCompostos(IEnumerable<decimal> indices) => indices.Aggregate(1M, (indiceAcumulado, indice) => indiceAcumulado * (1 + indice));

        /// <summary>
        /// Efetua o cálculo de juros simples
        /// </summary>
        /// <param name="indices">Listas de índices que devem ser calculados</param>
        /// <returns>O acumulado da lista de indices</returns>
        public static decimal CalcularJurosSimples(IEnumerable<decimal> indices) => indices.Sum();
    }
}

///Com base na data inicial calcula quantos dias faltam para fechar o mê e por consequencia qual a fração daquele mês foi utilizado
///A fração do mês utilizado
