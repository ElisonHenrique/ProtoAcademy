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
        public string createAluno(Aluno ObjetoAluno)
        {
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
