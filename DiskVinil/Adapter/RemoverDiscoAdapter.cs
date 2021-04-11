using DiskVinil.Bordas.Adapter;
using DiskVinil.Entities;
using DiskVinil.DTO.Disco.RemoverDisco;

namespace DiskVinil.Adapter
{
    public class RemoverDiscoAdapter : IRemoverDiscoAdapter
    {
        public Disco converterRequestParaDisco(RemoverDiscoRequest request)
        {
            var removerDisco = new Disco();
            removerDisco.id = request.id;
            return removerDisco;
        }
    }
}