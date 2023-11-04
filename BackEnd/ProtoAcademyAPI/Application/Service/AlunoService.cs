using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service 
{
    public class AlunoService : IAlunoService
    {
    private readonly IAlunoRepository _alunoRepository;

    public AlunoService(IAlunoRepository alunoRepository)
    {
      _alunoRepository = alunoRepository;
    }

    public string CreateAluno(Aluno ObjetoAluno)
        {
          if(ObjetoAluno.Idade < 18)
      {
        return "Não Foi Possivel Cadastrar o Aluno. Motivo:Aluno Menor de Idade.";
      }

      var resultado = _alunoRepository.CreateAluno(ObjetoAluno);  
      
      return "Cadastrado com Sucesso";
        }

        public List<Aluno> GetAllAlunos()
        {


      var resultado = _alunoRepository.GetAll();

      return resultado;
    }
    }
}
