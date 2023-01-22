using Estacionamento.Models;
using Xunit;

namespace Estacionamento.Testes
{
    public class Tests 
    {
        //Arrange
        //Act
        //Assert 
      
        [Fact(DisplayName ="Teste n 1")]
        [Trait("Funcionalidade","Acelerar")]
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
        [Trait("Funcionalidade", "Freiar")]
        public void TestaVeiculoFreiar()
        {
            //Arrange
            var veiculo = new Veiculo();

            //Act
            veiculo.Frear(15);

            //Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }


        [Fact(DisplayName = "Teste n°3", Skip = "Teste ainda não implementado")]
        public void ValidaNomeProprietario()
        {
            // Exemplo de utilização do Skip
        }


    }
}