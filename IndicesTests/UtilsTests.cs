using System;
using System.Collections.Generic;
using CalculadorIndices.IndicesCorrecao;
using Xunit;

namespace IndicesTests
{
    public class UtilsTests
    {
        [Fact]
        public void CalcularJurosCompostos()
        {
            List<decimal> indices = new List<decimal> { 0.5M, 0.3M };
            Assert.Equal(0.15M, Utils.CalcularJurosCompostos(indices));
        }
    }
}
