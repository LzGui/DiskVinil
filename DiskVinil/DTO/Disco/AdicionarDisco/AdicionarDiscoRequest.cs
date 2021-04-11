using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiskVinil.DTO.Disco.AdicionarDisco
{
    public class AdicionarDiscoRequest
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string autor { get; set; }
        public DateTime ano { get; set; }
        public char lado { get; set; }
        public int faixa { get; set; }
    }
}
