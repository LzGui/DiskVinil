using DiskVinil.Bordas.Adapter;
using DiskVinil.Entities;
using DiskVinil.DTO.Disco.AdicionarDisco;

namespace DiskVinil.Adapter
{
    public class AdicionarDiscoAdapter : IAdicionarDiscoAdapter
    {
        public Disco converterRequestParaDisco(AdicionarDiscoRequest request)
        {
            var novoDisco = new Disco();
            novoDisco.nome = request.nome;
            novoDisco.autor = request.autor;
            novoDisco.ano = request.ano;
            novoDisco.lado = request.lado;
            novoDisco.faixa = request.faixa;
            return novoDisco;
        }
    }
}