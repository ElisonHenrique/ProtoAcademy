using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Domain.Interface;

namespace Domain.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase

  { //para fazer uma injeção de dependencia selecionar a linha private readonly IAlunoService _alunoService; apertar em soluções rapidas e gerar construtor.
    private readonly IAlunoService _alunoService;

    public AlunoController(IAlunoService alunoService)
    {
      _alunoService = alunoService;
    }

    [HttpPost(Name = "CreateAluno")]
        public ActionResult CreateAluno(Aluno ObjetoAluno)
        {
            _alunoService.CreateAluno(ObjetoAluno);

            return Ok(ObjetoAluno);

        }

        [HttpGet("GetAllAlunos")]
        public ActionResult GetAllAlunos()
        {
      
      var resultado = _alunoService.GetAllAlunos();

      return Ok(resultado);
        }

    }
}

