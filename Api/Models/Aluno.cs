namespace Api.Models
{
    public class Aluno
    {

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? RMA { get; set; }
        public string? Pai { get; set; }
        public string? Mae { get; set; }
        public Escola? Escola { get; set; }
        public Professor? Professor { get; set; }

    }
}
