using DiskVinil.DTO.Disco.RetornarDiscoPorId;

namespace DiskVinil.Bordas.UseCase
{
    public interface IRetornarDiscoPorIdUseCase
    {
        RetornarDiscoPorIdResponse Executar(RetornarDiscoPorIdRequest request);
    }
}
