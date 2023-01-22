using Estacionamento.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Estacionamento.Testes
{
    public class AutomovelTestes : IDisposable
    {
        public ITestOutputHelper _output { get;  }
        public Veiculo carro { get; }
        public AutomovelTestes(ITestOutputHelper outuput)
        {
            _output = _output;
            _output.WriteLine("Execução do Construtor");

            carro = new Veiculo();
            carro.Proprietario = "Carlos Silva";
            carro.Placa = "ZAP-7419";
            carro.Cor = "Verde";
            carro.Modelo = "Variante";

        }
        public void Dispose()
        {
            
        }
        [Fact(Skip = "Teste ainda não implementado")]
        public void ValidaPropriedadeAutomovel()
        {

        }


        [Fact]
        public void ExibeDadosProprioAutomovelEstacionadaNoPatio()
        {
            string dados = carro.ToString();
            
           // Assert.Contains("Tipo de Veiculo:", dados);
        }
    }
}
