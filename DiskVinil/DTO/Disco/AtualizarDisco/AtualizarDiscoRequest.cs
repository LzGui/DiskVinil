using System;

namespace DiskVinil.DTO.Disco.AtualizarDisco
{
    public class AtualizarDiscoRequest
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string autor { get; set; }
        public DateTime ano { get; set; }
        public char lado { get; set; }
        public int faixa { get; set; }
    }
}
