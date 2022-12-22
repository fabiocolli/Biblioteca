using Bibliteca.Dominio.Entidades;
using Bibliteca.Dominio.Interfaces;
using System.Data.Entity;

namespace Biblioteca.Infra.Dados.Repositorios
{
    public class RepositorioItemEmprestado : RepositorioBase<ItemEmprestado>, IRepositorioItemEmprestado
    {
        public IEnumerable<ItemEmprestado> BuscaItensEmprestadosPorPessoa(int idPessoa) => _db.ItenEmprestados
                .Include(ie => ie.IdPessoa)
                .AsNoTracking()
                .ToList()
                .Where(ie => ie.IdPessoa == idPessoa);

        public IEnumerable<ItemEmprestado> BustaItensEmprestadosPorLivro(int IdLivro) => _db.ItenEmprestados
                .Include(ie => ie.IdLivro)
                .Where(ie => ie.IdLivro == IdLivro)
                .ToList();
    }
}
