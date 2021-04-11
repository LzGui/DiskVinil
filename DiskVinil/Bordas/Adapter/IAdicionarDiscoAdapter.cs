using DiskVinil.DTO.Disco.AdicionarDisco;
using DiskVinil.Entities;

namespace DiskVinil.Bordas.Adapter
{
    public interface IAdicionarDiscoAdapter
    {
        public Disco converterRequestParaDisco(AdicionarDiscoRequest request);
    }
}
