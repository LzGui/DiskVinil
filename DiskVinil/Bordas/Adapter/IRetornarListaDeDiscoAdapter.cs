using DiskVinil.DTO.Disco.RetornarListaDeDisco;
using DiskVinil.Entities;

namespace DiskVinil.Bordas.Adapter
{
    public interface IRetornarListaDeDiscoAdapter
    {
        public Disco converterRequestParaDisco(RetornarListaDeDiscoRequest request);
    }
}
