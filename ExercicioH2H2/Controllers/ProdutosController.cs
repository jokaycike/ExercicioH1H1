using ExercicioH2H2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExercicioH2H2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : Controller
    {
        private static List<Produto> listaProdutos = new List<Produto>();


        [HttpPost]
        public IActionResult CriarProduto(Produto novoProduto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            listaProdutos.Add(novoProduto);
            return Ok("Produto criado com sucesso!");
        }
    }
}
