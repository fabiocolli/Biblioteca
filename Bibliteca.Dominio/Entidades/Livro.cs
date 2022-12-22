namespace Bibliteca.Dominio.Entidades
{
    public class Livro
    {
        public enum EstadoLivro
        {
            Emprestado, Disponível, EmRestauracao
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AnoLancamento { get; set; }
        public string NomeAutor { get; set; }
        public DateTime DtCadastro { get; set; }
        public EstadoLivro StatusLivro { get; set; }
        public virtual IEnumerable<ItemEmprestado> ItemEmprestado { get; set; } = new List<ItemEmprestado>();

        public bool PodeSerEmprestado()
        {
            return StatusLivro == EstadoLivro.Disponível;
        }
    }
}
