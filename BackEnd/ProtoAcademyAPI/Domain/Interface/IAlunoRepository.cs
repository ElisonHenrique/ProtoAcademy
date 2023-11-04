using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
  public interface IAlunoRepository 
  {
    string CreateAluno(Aluno aluno);

    List<Aluno> GetAll();
  }
}
