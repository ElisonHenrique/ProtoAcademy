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
            var listaAluno = new List<Aluno>();

            var ObjetoAluno = new Aluno();
            ObjetoAluno.Matricula = 1234;
            ObjetoAluno.Nome = "Marcelo";

            var ObjetoAluno2 = new Aluno();
            ObjetoAluno2.Matricula = 12345;
            ObjetoAluno2.Nome = "Matheus";

            var ObjetoAluno3 = new Aluno();
            ObjetoAluno3.Matricula = 123456;
            ObjetoAluno3.Nome = "João";

            listaAluno.Add(ObjetoAluno);
            listaAluno.Add(ObjetoAluno2);
            listaAluno.Add(ObjetoAluno3);

            return listaAluno;
        }
    }
}
