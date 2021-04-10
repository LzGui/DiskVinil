using DiskVinil.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiskVinil.Services
{
    public interface IDiscoService
    {
        bool AdicionarDisco(Disco disco);
        List<Disco> RetornarListaDisco();
        Disco RetornarDiscoPorId(int id);
        bool AtualizarDisco(Disco novoDisco);
        bool DeletarDisco(int id);

    }
}
