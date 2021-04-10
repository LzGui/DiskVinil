using DiskVinil.Context;
using DiskVinil.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DiskVinil.Services
{
    public class DiscoService : IDiscoService
    {
        private readonly LocalDbContext _local;

        public DiscoService(LocalDbContext local)
        {
            _local = local;
        }
        public bool AdicionarDisco(Disco disco)
        {
            _local.discos.Add(disco);
            _local.SaveChanges();
            return true;
        }

        public bool AtualizarDisco(Disco novoDisco)
        {
            _local.discos.Attach(novoDisco);
            _local.Entry(novoDisco).State = EntityState.Modified;
            _local.SaveChanges();
            return true;
        }

        public bool DeletarDisco(int id)
        {
            var objApagar = _local.discos.Where(d => d.id == id).FirstOrDefault();
            _local.discos.Remove(objApagar);
            _local.SaveChanges();
            return true;
        }

        public List<Disco> RetornarListaDisco()
        {
            return _local.discos.ToList();
        }

        public Disco RetornarDiscoPorId(int id)
        {
            return _local.discos.Where(d => d.id == id).FirstOrDefault();
        }
    }
}
