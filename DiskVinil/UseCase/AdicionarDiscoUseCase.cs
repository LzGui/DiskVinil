using DiskVinil.Bordas.Adapter;
using DiskVinil.Bordas.UseCase;
using DiskVinil.Bordas.Repositorios;
using DiskVinil.DTO.Disco.AdicionarDisco;

namespace DiskVinil.UseCase
{
    public class AdicionarDiscoUseCase : IAdicionarDiscoUseCase
    {
        private readonly IRepositorioDisco _repositorioDisco;
        private readonly IAdicionarDiscoAdapter _adapter;

        public AdicionarDiscoUseCase(IRepositorioDisco repositorioDisco,
                                        IAdicionarDiscoAdapter adapter)
        {
            _repositorioDisco = repositorioDisco;
            _adapter = adapter;
        }

        public AdicionarDiscoResponse Executar(AdicionarDiscoRequest request)
        {
            var response = new AdicionarDiscoResponse();

            try
            {

                var discoAdicionar = _adapter.converterRequestParaDisco(request);
                var id = _repositorioDisco.Add(discoAdicionar);
                response.msg = "Disco adicionado com sucesso";
                response.id = discoAdicionar.id;
                return response;
            }
            catch
            {
                response.msg = "Erro ao adicionar o disco";
                return response;
            }

        }
    }
}
