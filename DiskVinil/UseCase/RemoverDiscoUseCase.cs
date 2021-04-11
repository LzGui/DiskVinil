
using DiskVinil.Bordas.UseCase;
using DiskVinil.Bordas.Repositorios;
using DiskVinil.DTO.Disco.RemoverDisco;
using System;

namespace DiskVinil.UseCase
{
    public class RemoverDiscoUseCase : IRemoverDiscoUseCase
    {
        private readonly IRepositorioDisco _repositorioDisco;

        public RemoverDiscoUseCase(IRepositorioDisco repositorioDisco)
        {
            _repositorioDisco = repositorioDisco;
        }

        public RemoverDiscoResponse Executar(RemoverDiscoRequest request)
        {
            var response = new RemoverDiscoResponse();
            try
            {
                _repositorioDisco.Remove(request.id);
                response.msg = "Removido com sucesso";
                return response;
            }
            catch (Exception e)
            {
                throw new System.Exception(e.Message);
            }
        }

    }
}
