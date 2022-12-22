namespace Bibliteca.Dominio.Entidades
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime DtCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual IEnumerable<ItemEmprestado> ItemEmprestados { get; set; } = new List<ItemEmprestado>();

        public bool PodeFazerEmprestimso(Pessoa pessoa)
        {
            return pessoa.Ativo && Nascimento.AddYears(16) >= DateTime.Now;
        }
    }
}
