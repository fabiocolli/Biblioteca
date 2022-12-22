namespace Bibliteca.Dominio.Entidades
{
    public class ItemEmprestado
    {
        public int IdPessoa { get; set; }
        public int IdLivro { get; set; }
        public DateTime DtEmprestimo { get; set; }
        public DateTime DtDevoluPrevista
        {
            set
            {
                DtDevoluPrevista = DateTime.Now.AddDays(7);
            }
        }
        public decimal ValorDaMulta { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        public virtual Livro Livro { get; set; }

        public bool PodeFazerEmprestimo(Pessoa pessoa)
        {
            return false;
        }
    }
}
