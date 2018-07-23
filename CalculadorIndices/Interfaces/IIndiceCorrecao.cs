using System;
using System.Collections.Generic;
using CalculadorIndices.Domain;

namespace CalculadorIndices.Interfaces
{
    public interface IIndiceCorrecao
    {
        /// <summary>
        /// Corrige o valor sem considerar o cálculo de Pró-rata.
        /// </summary>
        /// <param name="valorInicial">Valor base a ser corrigido</param>
        /// <param name="indices">Valores dos indíces, em percentual, utilizados para a correção do valor</param>
        /// <returns>Resumo do cálculo contendo: o indice acumulado, o valor total</returns>
        ValorCorrigido Corrigir(decimal valorInicial, IEnumerable<Indice> indices);

        /// <summary>
        /// Corrige o valor considerando cálculo de Pró-rata no mês inicial.
        /// </summary>
        /// <param name="valorInicial">Valor base a ser corrigido</param>
        /// <param name="indices">Valores dos indíces, em percentual, utilizados para a correção do valor</param>
        /// <param name="dataInicial">Data do primeiro vencimento</param>
        /// <returns>Resumo do cálculo contendo: o indice acumulado, o valor total</returns>
        ValorCorrigido Corrigir(decimal valorInicial, IEnumerable<Indice> indices, DateTime dataInicial);        
    }

    public interface IIndiceCorrecaoDiscriminado
    {
        /// <summary>
        /// Corrige o valor discriminando cada etapa do cálculo.
        /// Não efetua o cálculo de Pró-rata.
        /// </summary>
        /// <param name="valorInicial">Valor base a ser corrigido</param>
        /// <param name="indices">Valores dos indíces, em percentual, utilizados para a correção do valor</param>        
        /// <returns>Resumo dos cálculos contendo em cada registro: a competência atual, o seu indice acumulado e o seu valor total</returns>
        IEnumerable<ValorCorrigidoPorCompetencia> CorrigirEDiscriminar(decimal valorInicial, IEnumerable<Indice> indices);

        /// <summary>
        /// Corrige o valor discriminando cada etapa do cálculo.
        /// Efetua o cálculo de Pró-rata do mês inicial.
        /// </summary>
        /// <param name="valorInicial">Valor base a ser corrigido</param>
        /// <param name="indices">Valores dos indíces, em percentual, utilizados para a correção do valor</param>        
        /// <param name="dataInicial">Data do primeiro vencimento</param>
        /// <returns>Resumo dos cálculos contendo em cada registro: a competência atual, o seu indice acumulado e o seu valor total</returns>
        IEnumerable<ValorCorrigidoPorCompetencia> CorrigirEDiscriminar(decimal valorInicial, IEnumerable<Indice> indices, DateTime dataInicial);
    }
}