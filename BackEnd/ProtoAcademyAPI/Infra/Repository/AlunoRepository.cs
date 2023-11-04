using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
  public class AlunoRepository : IAlunoRepository
  {
    public string CreateAluno(Aluno aluno)
    {
      return "Salvo Com Sucesso";
    }

    public List<Aluno> GetAll()
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
