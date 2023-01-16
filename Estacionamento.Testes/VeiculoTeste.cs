using Estacionamento.Models;
using NUnit.Framework;
using Xunit;

namespace Estacionamento.Testes
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Fact]
        public void TestaVeiculoAcelerar()
        {
            var veiculo = new Veiculo();
            veiculo.Acelerar(10);

            Assert.Equals(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoFreiar()
        {
            var veiculo = new Veiculo();
            veiculo.Frear(15);
            Assert.Equals(-150, veiculo.VelocidadeAtual);
        }
    }
}