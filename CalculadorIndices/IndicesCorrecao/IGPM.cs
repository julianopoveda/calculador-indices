using CalculadorIndices.Domain;
using CalculadorIndices.Interfaces;
using System;
using System.Collections.Generic;

namespace CalculadorIndices.IndicesCorrecao
{
    public class IGPM : IIndiceCorrecao, IIndiceCorrecaoDiscriminado
    {
        public ValorCorrigido Corrigir(decimal valorInicial, IEnumerable<Indice> indices)
        {
            throw new NotImplementedException();
        }

        public ValorCorrigido Corrigir(decimal valorInicial, IEnumerable<Indice> indices, DateTime dataInicial)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ValorCorrigido> CorrigirEDiscriminar(decimal valorInicial, IEnumerable<Indice> indices)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ValorCorrigido> CorrigirEDiscriminar(decimal valorInicial, IEnumerable<Indice> indices, DateTime dataInicial)
        {
            throw new NotImplementedException();
        }
    }
}
