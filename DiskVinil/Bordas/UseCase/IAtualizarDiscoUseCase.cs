using DiskVinil.DTO.Disco.AtualizarDisco;

namespace DiskVinil.Bordas.UseCase
{
    public interface IAtualizarDiscoUseCase
    {
        AtualizarDiscoResponse Executar(AtualizarDiscoRequest request);
    }
}