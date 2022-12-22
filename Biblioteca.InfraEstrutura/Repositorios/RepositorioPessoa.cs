using Bibliteca.Dominio.Entidades;
using Bibliteca.Dominio.Interfaces;

namespace Biblioteca.Infra.Dados.Repositorios
{
    public class RepositorioPessoa : RepositorioBase<Pessoa>, IRepositorioPessoa
    {
        public IEnumerable<Pessoa> BuscarPessoaComAniversarioHoje()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pessoa> BuscarPessoasAtivas()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pessoa> BuscarPorNome(string nomePessoa)
        {
            throw new NotImplementedException();
        }
    }
}
