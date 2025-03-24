namespace Api.Models
{
    public class Aluno
    {

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? RMA { get; set; }
        public string? Pai { get; set; }
        public string? Mae { get; set; }
        public int EscolaID { get; set; }
        public int? ProfessorID { get; set; }

    }
}
 