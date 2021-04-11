using DiskVinil.Entities;
using DiskVinil.DTO.Disco.AtualizarDisco;
using DiskVinil.Bordas.Adapter;

namespace DiskVinil.Adapter
{
    public class AtualizarDiscoAdapter : IAtualizarDiscoAdapter
    {
        public Disco converterRequestParaDisco(AtualizarDiscoRequest request)
        {
            var atualizarDisco = new Disco();
            atualizarDisco.nome = request.nome;
            atualizarDisco.autor = request.autor;
            atualizarDisco.ano = request.ano;
            atualizarDisco.lado = request.lado;
            atualizarDisco.faixa = request.faixa;
            return atualizarDisco;
        }
    }
}