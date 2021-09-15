using System;

namespace API.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }

        //constructor do jeito normal
        // public Produto() { CriadoEm = DateTime.Now; }

        // constructor com arrow function
        public Produto() => CriadoEm = DateTime.Now;

        //ToString usando a arrow function 
        public override string ToString() => 
            $"Nome: {Nome} | Preço {Preco.ToString("C2")} | Criado em: {CriadoEm}";
    }
}