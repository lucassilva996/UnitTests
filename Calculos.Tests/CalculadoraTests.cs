using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculos.Tests
{
    [TestClass]
    public class CalculadoraTests
    {
        [TestMethod]
        public void Soma_DeveRetornarOValorCorreto()
        {
            Calculadora c = new Calculadora();
            var resultado = c.Soma(10,20);
            //verifica se o resultado é igual a 30
            Assert.AreEqual(30, resultado);

        }

        [DataTestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        public void RestoDivisao_DeveRetornarZero(int value)
        {
            Calculadora c = new Calculadora();
            var resultado = c.RestoDivisao(10,3);
            //Verifica se o quociente da divisão é 3 e o resto 1
            Assert.AreEqual(3, resultado.quociente);
            Assert.AreEqual(1, resultado.resto);
        }

        [TestMethod]
        public void Subtracao_DeveRetornarOValorCorreto()
        {
            Calculadora c = new Calculadora();
            var resultado = c.Subtracao(20,10);
            //verifica se o resultado é igual a 10
            Assert.AreEqual(10, resultado);
        }

        [TestMethod]
        public void Divisao_DeveRetornarOValorCorreto()
        {
            Calculadora c = new Calculadora();
            var resultado = c.Divisao(100,10);
            //verifica se o resultado é igual a 10
            Assert.AreEqual(10, resultado);
        }

        [TestMethod]
        public void Multiplicacao_DeveRetornarOValorCorreto()
        {
            Calculadora c = new Calculadora();
            var resultado = c.Multiplicacao(5,2);
            //verifica se o resultado é igual a 10
            Assert.AreEqual(10,resultado);
        }

    }

}