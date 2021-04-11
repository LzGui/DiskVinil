using DiskVinil.Context;
using DiskVinil.Entities;
using DiskVinil.Bordas.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiskVinil.Repositorios
{
    public class RepositorioDisco : IRepositorioDisco
    {
        private readonly LocalDbContext _local;

        public RepositorioDisco(LocalDbContext local)
        {
            _local = local;
        }

        public int Add(Disco request)
        {
            _local.discos.Add(request);
            _local.SaveChanges();
            return request.id;
        }

        public void Remove(int id)
        {
            var obj = _local.discos.Where(d => d.id == id).FirstOrDefault();
            if (obj == null)
            {
                throw new System.Exception();
            }
            _local.discos.Remove(obj);
            _local.SaveChanges();
        }
    }
}