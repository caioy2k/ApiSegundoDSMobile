namespace Api.Models
{
    public class Escola
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? CNPJ { get; set; }
        public int AlunoID { get; set; }
        public int ProfessorID { get; set; }


    }
}
