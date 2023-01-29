using Estacionamento.Modelos;
using Xunit;
using NUnit;
namespace Estacionamento.Testes
{
    public class VeiculoTeste 
    {
        //Arrange
        //Act
        //Assert 
      
        [Test]
        //[Trait("Funcionalidade","Acelerar")]
        public void TestaVeiculoAcelerarComParametro10()
        {
            //Arrange
            var veiculo = new Veiculo();

            //Act
            veiculo.Acelerar(10);

            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
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