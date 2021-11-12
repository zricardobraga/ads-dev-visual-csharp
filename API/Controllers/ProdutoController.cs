using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController] //anotação
	[Route("api/produto")] //rota de api
    public class ProdutoController : ControllerBase
    {
        private readonly DataContext _context;        
        
        //constructor do controller que pede o objeto necessário
        public ProdutoController(DataContext context)
        {
            _context = context;
        }
        //POST: api/produto/create
		[HttpPost]
		[Route("create")]
		public IActionResult Create([FromBody]Produto produto) 
		{
            produto.Categoria = _context.Categorias.Find(produto.CategoriaId);
            _context.Produtos.Add(produto);
            //confirma o objeto salvo no banco de dados
            _context.SaveChanges(); 
            return Created("Produto adicionado com sucesso!", produto);
		}
        //GET: api/produto/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Produtos
        .Include(produto => produto.Categoria)
        .ToList());

        //GET: api/produto/getById/1
        [HttpGet]
        [Route("getbyid/{id}")]
        //para que seja possível retornar a mensagem de erro estilizada, temos que mudar o tipo de retorno para IActionResult (ao invés de um objeto Produto)
        public IActionResult GetById([FromRoute]int id)
        {   
            Produto produto = _context.Produtos.Include(produto => produto.Categoria).FirstOrDefault( produto => produto.Id == id);
            if (produto == null)
            {
                return NotFound("Produto não encontrado");
            }
            return Ok(produto);
        }

        //DELETE: /api/produto/delete/nome
        // [HttpDelete]
        // [Route("delete/{name}")]
        // public IActionResult Delete([FromRoute] string name)
        // {   
        //     //busca o obbjeto na tabela de produtos com base no nome - usa a expressão lambda
        //     Produto produto = _context.Produtos.FirstOrDefault( produto => produto.Nome == name );
        //     if (produto == null) 
        //     { 
        //         return NotFound("Produto não encontrado"); 
        //     } //testa se o produto foi encontrado no DB  
            
        //     _context.Produtos.Remove(produto); //remove o produto do DB
        //     _context.SaveChanges(); //salva a mudança no DB
        //     return Ok(produto); //retorna mensagem de sucesso
        // }
        
        //DELETE: /api/produto/delete/id
        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult DeleteById([FromRoute] int id)
        {   
            //busca o obbjeto na tabela de produtos com base no nome - usa a expressão lambda
            // Produto produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);
            Produto produto = _context.Produtos.Find(id);
            if (produto == null) 
            { 
                return NotFound("Produto não encontrado"); 
            } //testa se o produto foi encontrado no DB  
            
            _context.Produtos.Remove(produto); //remove o produto do DB
            _context.SaveChanges(); //salva a mudança no DB
            return Ok(produto); //retorna mensagem de sucesso
        }

        //PUT: api/produto/update
		[HttpPut]
		[Route("update")]
		public IActionResult Update([FromBody]Produto produto) 
		{
            _context.Produtos.Update(produto);
            //confirma o objeto salvo no banco de dados
            _context.SaveChanges(); 
            return Ok(produto);
		}  
    }
}