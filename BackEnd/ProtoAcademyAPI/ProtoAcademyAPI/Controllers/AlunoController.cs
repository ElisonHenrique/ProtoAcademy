using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Domain.Interface;

namespace Domain.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase

    {
        private readonly IAlunoService _alunoService;
        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpPost(Name = "CreateAluno")]
        public ActionResult CreateAluno(Aluno ObjetoAluno)
        {
            string Resultado = _alunoService.createAluno(ObjetoAluno);

            return Ok(Resultado);

        }

        [HttpGet("GetAllAlunos")]
        public ActionResult GetAllAlunos()
        {
            var listaAluno = _alunoService.GetAllAlunos();

            return Ok(listaAluno);
        }

    }
}

