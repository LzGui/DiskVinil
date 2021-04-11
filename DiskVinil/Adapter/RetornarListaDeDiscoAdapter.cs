using DiskVinil.Bordas.Adapter;
using DiskVinil.DTO.Disco.RetornarListaDeDisco;
using DiskVinil.Entities;



namespace DiskVinil.Adapter
{
    public class RetornarListaDeDiscoAdapter : IRetornarListaDeDiscoAdapter
    {
        public Disco converterRequestParaDisco(RetornarListaDeDiscoRequest request)
        {
            var retornaListaDisco = new Disco();
            retornaListaDisco.nome = request.nome;
            retornaListaDisco.autor = request.autor;
            retornaListaDisco.ano = request.ano;
            retornaListaDisco.lado = request.lado;
            retornaListaDisco.faixa = request.faixa;
            return retornaListaDisco;
        }
    }
}