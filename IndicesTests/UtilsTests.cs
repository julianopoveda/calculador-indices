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
            List<decimal> indices = new List<decimal> { 0.05M, 0.03M, 0.025M };
            Assert.Equal(1.1085375M, Utils.CalcularJurosCompostos(indices));
        }
    }
}
