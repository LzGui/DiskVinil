using DiskVinil.DTO.Disco.RetornarListaDeDisco;

namespace DiskVinil.Bordas.UseCase
{
    public interface IRetornarListaDeDiscoUseCase
    {
        RetornarListaDeDiscoResponse Executar(RetornarListaDeDiscoRequest request);
    }
}
