using Microsoft.AspNetCore.Mvc;
using ProtoAcademyAPI.Entities;

namespace ProtoAcademyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase

    {
        [HttpPost(Name = "PlanoAluno")]
        public ActionResult PlanoAluno(Aluno VariavelAluno)
        {
            string MensagemRetorno;
         

            if (VariavelAluno.Plano == "P")
            {
                MensagemRetorno = "Você é Um Aluno Que Me Traz Alegria";
            }
            else if (VariavelAluno.Plano == "PP")
            {
                MensagemRetorno = "Você é Um Aluno Que Me Traz Muita Alegria";
            }
            else 
            {
                MensagemRetorno = "Você é a Alegria em Pessoa , Mas Pagar Que è Bom Nada Em";
            }

           

            return Ok(MensagemRetorno);
        }
    }
}