using ExercicioH1H1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExercicioH1H1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : Controller
    {

        private static List<Aluno> listaAlunos = new List<Aluno>();


        [HttpPost]
        public IActionResult CriarAluno(Aluno novoAluno)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            listaAlunos.Add(novoAluno);
            return Ok("Aluno criado com sucesso!");
        }

    }
}
