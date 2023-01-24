using Estacionamento.Modelos;
using Xunit;

namespace Estacionamento.Testes
{
    public class PatioTestes
    {
        public PatioTestes()
        {

        }


        [Fact]
        public void ValidaFaturamento()
        {
            //ARRANGE

            //Arranje
            Patio estacionamento = new Patio();

            var veiculo = new Veiculo();
            veiculo.Proprietario = "André Silva";
            veiculo.Placa = "ABC-0101";
            veiculo.Modelo = "Fusca";
            veiculo.Acelerar(10);
            veiculo.Frear(5);
            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            //Act
            double faturamento = estacionamento.TotalFaturado();

            //Assert
            Assert.Equal(2, faturamento);

        }

        [Theory]
        [InlineData("André Silva", "ASD-1498", "preto", "Gol")]
        [InlineData("Jose Silva", "POL-9242", "Cinza", "Fusca")]
        [InlineData("André Silva", "GDR-6524", "Azul", "Opala")]
        [InlineData("André Silva", "OKU-1498", "Amarelo", "HB20")]
        [InlineData("André Silva", "QWZ-5154", "Verde", "Santana")]
        [InlineData("André Silva", "PLU-8472", "Branco", "Logan")]
        public void ValidaFaturamentoVeiculos(string proprietario,
                                                        string placa,
                                                        string cor,
                                                        string modelo)
        {
            //Arranje
            Patio estacionamento = new Patio();

            var veiculo = new Veiculo();
            veiculo.Proprietario = proprietario;
            veiculo.Placa = placa;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;
            veiculo.Acelerar(10);
            veiculo.Frear(5);
            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            //Act
            double faturamento = estacionamento.TotalFaturado();

            //Assert
            Assert.Equal(2, faturamento);
        }


        [Theory]
        [InlineData("André Silva", "ASD-1498", "preto", "Gol")]         
        public void LocalizaVeiculoNoPatio(string proprietario,
                                                       string placa,
                                                       string cor,
                                                       string modelo)
        {
            //Arranje

            Patio estacionamento = new Patio();

            var veiculo = new Veiculo();
            veiculo.Proprietario = proprietario;
            veiculo.Placa = placa;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;

            //Act
            var consultado = estacionamento.PesquisaVeiculo(veiculo.Placa);

            //Assert
            Assert.Equal(veiculo.Placa, consultado.Placa);
        }

        [Fact]
        public void AlterarDadosVeiculos()
        {
            Patio estacionamento = new Patio();
            Veiculo veiculo = new Veiculo();
            veiculo.Proprietario = "José Silva";
            veiculo.Placa = "ZXC-8524";
            veiculo.Cor = "Verde";
            veiculo.Modelo = "Opala";
            estacionamento.RegistrarEntradaVeiculo(veiculo);

            Veiculo veiculoAlterado = new Veiculo();
            veiculo.Proprietario = "José Silva";
            veiculo.Placa = "ZXC-8524";
            veiculo.Cor = "Preto"; //Alterado
            veiculo.Modelo = "Opla";

            Veiculo alterado = estacionamento.AlterarDadosVeiculos(veiculoAlterado);

            Assert.Equal(alterado.Cor, veiculoAlterado.Cor);

        }

    }
}
