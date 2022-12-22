using Bibliteca.Dominio.Entidades;
using Bibliteca.Dominio.Interfaces;

namespace Biblioteca.Infra.Dados.Repositorios
{
    public class RepositorioPessoa : RepositorioBase<Pessoa>, IRepositorioPessoa
    {
        public IEnumerable<Pessoa> BuscarPessoaComAniversarioHoje()
        {
            return _db.Pessoas
                .AsNoTracking()
                .ToList()
                .Where(p => p.Nascimento.Day == DateTime.Now.Day);
        }

        public IEnumerable<Pessoa> BuscarPessoasAtivas()
        {
            return _db.Pessoas
                .AsNoTracking()
                .ToList()
                .Where(p => p.Ativo);
        }

        public IEnumerable<Pessoa> BuscarPorNome(string nomePessoa)
        {
            return _db.Pessoas
                .AsNoTracking()
                .ToList()
                .Where(p => p.Nome.Contains(nomePessoa));
        }
    }
}
