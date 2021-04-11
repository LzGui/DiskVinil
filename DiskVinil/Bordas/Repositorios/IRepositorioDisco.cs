using DiskVinil.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiskVinil.Bordas.Repositorios
{
    public interface IRepositorioDisco
    {
        public int Add(Disco request);
        public void Remove(int id);
    }
}