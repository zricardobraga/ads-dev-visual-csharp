using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers

[ApiController]
[Route("api/produto")]

public class ProdutoController : ControllerBase
{
	public ProdutoController()
	{
        //POST: api/produto/create
        [httpPost] 
        [Route("create")]
        public Produto Create(Produto produto) 
        {
            return produto;
        }
	}
}
