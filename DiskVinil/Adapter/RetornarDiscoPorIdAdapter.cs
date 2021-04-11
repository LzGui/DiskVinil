using DiskVinil.Bordas.Adapter;
using DiskVinil.DTO.Disco.RetornarDiscoPorId;
using DiskVinil.Entities;


namespace DiskVinil.Adapter
{
    public class RetornarDiscoPorIdAdapter : IRetornarDiscoPorIdAdapter
    {
        public Disco converterRequestParaDisco(RetornarDiscoPorIdRequest request)
        {
            var retornoDisco = new Disco();
            retornoDisco.id = request.id;
            return retornoDisco;
        }
    }
}