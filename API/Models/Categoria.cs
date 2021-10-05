using System;

namespace API.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime CriadoEm { get; set; }
        
        public Categoria() => CriadoEm = DateTime.Now;

    }
}