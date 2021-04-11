using DiskVinil.DTO.Disco.AtualizarDisco;
using DiskVinil.Entities;

namespace DiskVinil.Bordas.Adapter
{
    public interface IAtualizarDiscoAdapter
    {
        public Disco converterRequestParaDisco(AtualizarDiscoRequest request);
    }
}
