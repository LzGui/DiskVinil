using DiskVinil.Bordas.Adapter;
using DiskVinil.Bordas.Repositorios;
using DiskVinil.DTO.Disco.AdicionarDisco;
using DiskVinil.Entities;
using DiskVinil.Teste.Builder;
using DiskVinil.UseCase;
using FluentAssertions;
using Moq;
using Xunit;

namespace DiskVinil.Teste.UseCase
{
    public class AdicionarDiscoUseCaseTest
    {
        private readonly Mock<IRepositorioDisco> _repositorioDisco;
        private readonly Mock<IAdicionarDiscoAdapter> _adicionarDiscoAdapter;
        private readonly AdicionarDiscoUseCase _useCase;

        public AdicionarDiscoUseCaseTest()
        {
            _repositorioDisco = new Mock<IRepositorioDisco>();
            _adicionarDiscoAdapter = new Mock<IAdicionarDiscoAdapter>();
            _useCase = new AdicionarDiscoUseCase(_repositorioDisco.Object, 
                _adicionarDiscoAdapter.Object);
        }
        
        [Fact]
        public void Disco_AdicionarDisco_RetornarSucesso()
        {
            //Arrange
            var request = new AdicionarDiscoRequestBuilder().Build();
            var response = new AdicionarDiscoResponse();
            var disco = new Disco();
            disco.id = 1;
            response.msg = "Adicionado com sucesso";
            _repositorioDisco.Setup(repositorio => repositorio.Add(disco)).Returns(disco.id);
            _adicionarDiscoAdapter.Setup(adapter => adapter.converterRequestParaDisco(request)).Returns(disco);
            //Criar as variaveis
            //Act
            //Chamar as funções
            var result = _useCase.Executar(request);
            //Assert
            response.Should().BeEquivalentTo(result);
                //AS regras dos testes
        }

    }
}
