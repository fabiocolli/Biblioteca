using Bibliteca.Dominio.Entidades;
using Bibliteca.Dominio.Interfaces;

namespace Biblioteca.Infra.Dados.Repositorios
{
    public class RepositorioLivro : RepositorioBase<Livro>, IRepositorioLivro
    {
        public IEnumerable<Livro> BuscaPorAnoDeLancamento(int anoLancamento)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> BUscaPorAutor(string nomeAutor)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> BuscaPorTitulo(string tituloLivro)
        {
            throw new NotImplementedException();
        }
    }
}
