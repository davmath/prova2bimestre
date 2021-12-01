using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/inicializar")]
    public class InicializarDadosController : ControllerBase
    {
        private readonly DataContext _context;
        public InicializarDadosController(DataContext context)
        {
            _context = context;
        }

        //POST: api/inicializar/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create()
        {
            _context.Categorias.AddRange(new Categoria[]
                {
                    new Categoria { CategoriaId = 1, Nome = "Gamer" },


                }
            );
            _context.Produtos.AddRange(new Produto[]
                {
                    new Produto { ProdutoId = 1, Nome = "Intel I5", Preco = 1800, Quantidade = 1, CategoriaId = 1 },
                    new Produto { ProdutoId = 2, Nome = "Mouse Razer", Preco = 480, Quantidade = 2, CategoriaId = 1 },
                    new Produto { ProdutoId = 3, Nome = "Monitor Philips 22pol", Preco = 680, Quantidade = 3, CategoriaId = 1 },


                }
            );
            _context.SaveChanges();
            return Ok(new { message = "Dados inicializados com sucesso!" });
        }
    }
}