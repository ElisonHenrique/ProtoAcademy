namespace Domain.Entities
{
    public class Aluno
    {
        public int Matricula {  get; set; }
        public string Plano { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Data_de_Nascimento { get; set;}

        public string? Sexo { get; set;}

        public int Peso { get; set; }

        public string CPF { get; set;}

        public string?  Endereco { get; set;}
        

    }
}
