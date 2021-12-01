using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{

    [ApiController]
    [Route("api/formaspagamento")]

    public class FormasPagamentoController : ControllerBase
    {

        private readonly DataContext _context;

        public FormasPagamentoController(DataContext context)
        {
            _context = context;
        }


        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] FormasPagamento formasPagamento)
        {
            _context.FormasPagamentos.Add(formasPagamento);
            _context.SaveChanges();
            return Created("", formasPagamento);
        }

        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.FormasPagamentos.ToList());

    }
}