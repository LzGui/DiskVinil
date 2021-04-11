using DiskVinil.Bordas.Adapter;
using DiskVinil.Bordas.Repositorios;
using DiskVinil.Bordas.UseCase;
using DiskVinil.DTO.Disco.AtualizarDisco;

namespace DiskVinil.UseCase
{
    public class AtualizarDiscoUseCase : IAtualizarDiscoUseCase
    {
        private readonly IRepositorioDisco _repositorioDisco;
        private readonly IAtualizarDiscoAdapter _adapter;

        public AtualizarDiscoUseCase(IRepositorioDisco repositorioDisco,
                                        IAtualizarDiscoAdapter adapter)
        {
            _repositorioDisco = repositorioDisco;
            _adapter = adapter;
        }
        public AtualizarDiscoResponse Executar(AtualizarDiscoRequest request)
        {
            var response = new AtualizarDiscoResponse();

            try
            {

                var discoAtualizar = _adapter.converterRequestParaDisco(request);
                var id = _repositorioDisco.Add(discoAtualizar);
                response.msg = "Disco atualizado com sucesso";
                response.id = discoAtualizar.id;
                return response;
            }
            catch
            {
                response.msg = "Erro ao atualizar o disco";
                return response;
            }

        }
    }
}
