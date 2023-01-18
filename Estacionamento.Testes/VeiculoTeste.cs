using Estacionamento.Models;
using NUnit.Framework;
using Xunit;

namespace Estacionamento.Testes
{
    public class Tests 
    {
        //Arrange
        //Act
        //Assert 

        [SetUp]
        public void Setup()
        {
        }
      
        [Fact]
        public void TestaVeiculoAcelerar()
        {
            //Arrange
            var veiculo = new Veiculo();

            //Act
            veiculo.Acelerar(10);

            //Assert
            Assert.Equals(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoFreiar()
        {
            //Arrange
            var veiculo = new Veiculo();

            //Act
            veiculo.Frear(15);

            //Assert
            Assert.Equals(-150, veiculo.VelocidadeAtual);
        }
    }
}