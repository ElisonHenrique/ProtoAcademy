using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using System.Xml.Linq;

namespace ProtoAcademyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase

    {
        [HttpPost(Name = "CreateFuncionario")]
        public ActionResult CreateFuncionario(Funcionario ObjetoFuncionario)
        {
            string VariavelRetorno = "Retornado Com Sucesso";

            if (ObjetoFuncionario.Idade < 18)
            {
                string funcionarioMenor = "Esse Funcionario é Menor de Idade";
                    return Ok(funcionarioMenor);
            }

            return Ok(VariavelRetorno);

            

        }

        [HttpGet("GetAllFuncionario")]
        public ActionResult GetAllFuncionario()
        {
            var listaFuncionario = new List<Funcionario>();

            var ObjetoFuncionario = new Funcionario();
            ObjetoFuncionario.Nome = "Henrique";
            ObjetoFuncionario.Idade = 20;
            ObjetoFuncionario.Gênero = "Masculino";
            ObjetoFuncionario.CPF = "192.575.965-88";

            var ObjetoFuncionario2 = new Funcionario();
            ObjetoFuncionario2.Nome = "Matheus";
            ObjetoFuncionario2.Idade = 17;
            ObjetoFuncionario2.Gênero = "Masculino";
            ObjetoFuncionario2.CPF = "158.575.447-55";

            var ObjetoFuncionario3 = new Funcionario();
            ObjetoFuncionario3.Nome = "João";
            ObjetoFuncionario3.Idade = 28;
            ObjetoFuncionario3.Gênero = "Masculino";
            ObjetoFuncionario3.CPF = "457.684.965-90";


            listaFuncionario.Add(ObjetoFuncionario);
            listaFuncionario.Add(ObjetoFuncionario2);
            listaFuncionario.Add(ObjetoFuncionario3);


            return Ok(listaFuncionario);
        }

    }
    
}

