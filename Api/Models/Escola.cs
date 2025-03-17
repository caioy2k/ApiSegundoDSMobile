namespace Api.Models
{
    public class Escola
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? CNPJ { get; set; }
        public Aluno Aluno { get; set; }
        public Professor Professor { get; set; }


    }
}
