using DiskVinil.Entities;
using DiskVinil.DTO.Disco.RetornarDiscoPorId;

namespace DiskVinil.Bordas.Adapter
{
    public interface IRetornarDiscoPorIdAdapter
    {
        public Disco converterRequestParaDisco(RetornarDiscoPorIdRequest request);
    }
}
