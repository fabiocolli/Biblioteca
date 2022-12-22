namespace Biblioteca.Web.ViewModels
{
    public class ItemEmprestadoViewModel
    {
        public int IdPessoa { get; set; }
        public int IdLivro { get; set; }

        public virtual PessoaViewModel Pessoa { get; set; }

        public virtual LivroViewModel Livro { get; set; }
    }
}
