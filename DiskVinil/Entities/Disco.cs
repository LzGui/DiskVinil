using System;
using System.ComponentModel.DataAnnotations;

namespace DiskVinil.Entities
{
    public class Disco
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string autor { get; set; }
        public DateTime ano { get; set; }
        public char lado { get; set; }
        public int faixa { get; set; }
    }
}
