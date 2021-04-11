using DiskVinil.DTO.Disco.RemoverDisco;

namespace DiskVinil.Bordas.UseCase
{
    public interface IRemoverDiscoUseCase
    {
        RemoverDiscoResponse Executar(RemoverDiscoRequest request);
    }
}
