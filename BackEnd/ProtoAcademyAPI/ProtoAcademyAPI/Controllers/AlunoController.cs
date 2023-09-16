using Microsoft.AspNetCore.Mvc;
using ProtoAcademyAPI.Entities;

namespace ProtoAcademyAPI.Controllers
{
        [ApiController]
        [Route("[controller]")]
        public class AlunoController : ControllerBase
        {
           [HttpPost(Name = "CreateAluno")]
           public Aluno CreateAluno(Aluno alunoObject)
        {
            string retorno = "Aluno Criado com Sucesso";
            return alunoObject;
            
        }
        }

    }
