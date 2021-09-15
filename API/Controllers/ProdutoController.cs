using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers
{
    [ApiController] //anotação
	[Route("api/produto")] //rota de api
    public class ProdutoController : ControllerBase
    {
        private readonly DataContext _context;        
        //constructor do controller
        public ProdutoController(DataContext context)
        {
            _context = context;
        }

        //POST: api/produto/create
		[HttpPost]
		[Route("create")]
		public Produto Create(Produto produto) 
		{
            _context.Produtos.Add(produto);
            //confirma o objeto salvo no banco de dados
            _context.SaveChanges(); 
            return produto;
		}

        //GET: api/produto/list
        [HttpGet]
        [Route("list")]
        public List<Produto> List() => _context.Produtos.ToList();  
    }
}