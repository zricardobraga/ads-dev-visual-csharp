using System;

namespace API.Models
{
    public class Produto : BaseModel
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; } 
            
        // //ToString usando a arrow function 
        // public override string ToString() => 
        //     $"Nome: {Nome} | Preço {Preco.ToString("C2")} | Criado em: {CriadoEm}";
    }
}