using DiskVinil.DTO.Disco.AdicionarDisco;

namespace DiskVinil.Bordas.UseCase
{
    public interface IAdicionarDiscoUseCase
    {
        AdicionarDiscoResponse Executar(AdicionarDiscoRequest request);
    }
}
