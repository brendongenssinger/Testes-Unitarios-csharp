using System;
using System.Collections.Generic;
using System.Text;
using Estacionamento.Models;
using NUnit.Framework;
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

            var estacionamento = new Patio();
            var veiculo = new Veiculo();
            veiculo.Proprietario = "André Silva";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = "Verde";
            veiculo.Modelo = "Fusca";
            veiculo.Placa = "asd-999";

            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            //ACT
            double faturamento = estacionamento.TotalFaturado();

            // ASSERT
            Assert.Equals(2, faturamento);

        }

    }
}
