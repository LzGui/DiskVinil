
using DiskVinil.Adapter;
using DiskVinil.Bordas.Adapter;
using DiskVinil.Bordas.Repositorios;
using DiskVinil.DTO.Disco.RetornarListaDeDisco;

namespace DiskVinil.UseCase
{
    public class RetornarListaDiscoUseCase
    {
        private readonly IRepositorioDisco _repositorioDisco;
        private readonly IRetornarListaDeDiscoAdapter _adapter;

        public RetornarListaDiscoUseCase(IRepositorioDisco repositorioDisco,
                                        IRetornarListaDeDiscoAdapter adapter)
        {
            _repositorioDisco = repositorioDisco;
            _adapter = adapter;
        }

        public RetornarListaDeDiscoResponse Executar(RetornarListaDeDiscoAdapter request)
        {
            var response = new RetornarListaDeDiscoResponse();

            try
            {
                if (request.nome.Length < 20)
                {
                    response.msg = "Erro ao adicionar o disco";
                    return response;
                }

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