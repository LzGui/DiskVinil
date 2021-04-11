using DiskVinil.DTO.Disco.RemoverDisco;
using DiskVinil.Entities;

namespace DiskVinil.Bordas.Adapter
{
    public interface IRemoverDiscoAdapter
    {
        public Disco converterRequestParaDisco(RemoverDiscoRequest request);
    }
}
