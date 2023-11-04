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
      ObjetoAluno.Nome = "Henrique";
      ObjetoAluno.Idade = 20;
      ObjetoAluno.Data_de_Nascimento = "11/07/2003";
      ObjetoAluno.Matricula = 1234;
      ObjetoAluno.Plano = "simples";
      ObjetoAluno.Sexo = "Masculino";
      ObjetoAluno.Peso = 68;
      ObjetoAluno.CPF = "185.648.363-88";
      ObjetoAluno.Endereco = "Rua Da Esperança";

      var ObjetoAluno2 = new Aluno();
      ObjetoAluno2.Nome = "Moises";
      ObjetoAluno2.Idade = 28;
      ObjetoAluno2.Data_de_Nascimento = "07/10/1995";
      ObjetoAluno2.Matricula = 1234;
      ObjetoAluno2.Plano = "simples";
      ObjetoAluno2.Sexo = "Masculino";
      ObjetoAluno2.Peso = 80;
      ObjetoAluno2.CPF = "185.648.363-88";
      ObjetoAluno2.Endereco = "Rua Da Esperança";

      var ObjetoAluno3 = new Aluno();
      ObjetoAluno3.Nome = "João";
      ObjetoAluno3.Idade = 28;
      ObjetoAluno3.Data_de_Nascimento = "15/08/1995";
      ObjetoAluno3.Matricula = 1234;
      ObjetoAluno3.Plano = "simples";
      ObjetoAluno3.Sexo = "Masculino";
      ObjetoAluno3.Peso = 82;
      ObjetoAluno3.CPF = "185.648.363-88";
      ObjetoAluno3.Endereco = "Rua Da Esperança";


      listaAluno.Add(ObjetoAluno);
      listaAluno.Add(ObjetoAluno2);
      listaAluno.Add(ObjetoAluno3);

      return listaAluno;
    }
  }
}
