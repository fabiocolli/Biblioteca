using Bibliteca.Dominio.Entidades;
using Bibliteca.Dominio.Interfaces;

namespace Biblioteca.Infra.Dados.Repositorios
{
    public class RepositorioLivro : RepositorioBase<Livro>, IRepositorioLivro
    {
        public IEnumerable<Livro> BuscaPorAnoDeLancamento(int anoLancamento)
        {
            return _db.Livros
                .AsNoTracking()
                .ToList()
                .Where(l => l.AnoLancamento == anoLancamento);
        }

        public IEnumerable<Livro> BUscaPorAutor(string nomeAutor)
        {
            return _db.Livros
                .AsNoTracking()
                .ToList()
                .Where(l => l.NomeAutor.Contains(nomeAutor));
        }

        public IEnumerable<Livro> BuscaPorTitulo(string tituloLivro)
        {
            return _db.Livros
                .AsNoTracking()
                .ToList()
                .Where(l => l.Titulo.Contains(tituloLivro));
        }
    }
}
