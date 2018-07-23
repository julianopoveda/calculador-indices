using System;
using System.Collections.Generic;
using CalculadorIndices.Domain;

namespace CalculadorIndices.Interfaces
{
    public interface IIndiceCorrecao
    {
        /// <summary>
        /// Corrige o valor sem considerar o c�lculo de Pr�-rata.
        /// </summary>
        /// <param name="valorInicial">Valor base a ser corrigido</param>
        /// <param name="indices">Valores dos ind�ces, em percentual, utilizados para a corre��o do valor</param>
        /// <returns>Resumo do c�lculo contendo: o indice acumulado, o valor total</returns>
        ValorCorrigido Corrigir(decimal valorInicial, IEnumerable<Indice> indices);

        /// <summary>
        /// Corrige o valor considerando c�lculo de Pr�-rata no m�s inicial.
        /// </summary>
        /// <param name="valorInicial">Valor base a ser corrigido</param>
        /// <param name="indices">Valores dos ind�ces, em percentual, utilizados para a corre��o do valor</param>
        /// <param name="dataInicial">Data do primeiro vencimento</param>
        /// <returns>Resumo do c�lculo contendo: o indice acumulado, o valor total</returns>
        ValorCorrigido Corrigir(decimal valorInicial, IEnumerable<Indice> indices, DateTime dataInicial);        
    }

    public interface IIndiceCorrecaoDiscriminado
    {
        /// <summary>
        /// Corrige o valor discriminando cada etapa do c�lculo.
        /// N�o efetua o c�lculo de Pr�-rata.
        /// </summary>
        /// <param name="valorInicial">Valor base a ser corrigido</param>
        /// <param name="indices">Valores dos ind�ces, em percentual, utilizados para a corre��o do valor</param>        
        /// <returns>Resumo dos c�lculos contendo em cada registro: a compet�ncia atual, o seu indice acumulado e o seu valor total</returns>
        IEnumerable<ValorCorrigidoPorCompetencia> CorrigirEDiscriminar(decimal valorInicial, IEnumerable<Indice> indices);

        /// <summary>
        /// Corrige o valor discriminando cada etapa do c�lculo.
        /// Efetua o c�lculo de Pr�-rata do m�s inicial.
        /// </summary>
        /// <param name="valorInicial">Valor base a ser corrigido</param>
        /// <param name="indices">Valores dos ind�ces, em percentual, utilizados para a corre��o do valor</param>        
        /// <param name="dataInicial">Data do primeiro vencimento</param>
        /// <returns>Resumo dos c�lculos contendo em cada registro: a compet�ncia atual, o seu indice acumulado e o seu valor total</returns>
        IEnumerable<ValorCorrigidoPorCompetencia> CorrigirEDiscriminar(decimal valorInicial, IEnumerable<Indice> indices, DateTime dataInicial);
    }
}