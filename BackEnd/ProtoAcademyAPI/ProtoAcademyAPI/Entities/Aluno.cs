namespace ProtoAcademyAPI.Entities
{
    public class Aluno
    {
        public int matricula {  get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Data_de_Nascimento { get; set;}

        public string? Sexo { get; set;}

        public string CPF { get; set;}

        public string?  Endereço { get; set;}
        

    }
}
