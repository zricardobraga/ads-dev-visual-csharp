using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController] //anotação
	[Route("api/categoria")] //rota de api
    public class CategoriaController : ControllerBase
    {
        private readonly DataContext _context;
        public CategoriaController(DataContext context)
        {
            _context = context;
        }

        //POST: api/categoria/create
		[HttpPost]
		[Route("create")]
		public IActionResult Create([FromBody]Categoria categoria)
		{
            _context.Categorias.Add(categoria);
            //confirma o objeto salvo no banco de dados
            _context.SaveChanges(); 
            return Created("Categoria criada com sucesso!", categoria);
		}

        //GET: api/categoria/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Categorias.ToList());

    }
}