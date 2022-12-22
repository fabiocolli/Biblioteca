using Bibliteca.Dominio.Entidades;
using Bibliteca.Dominio.Interfaces;

namespace Biblioteca.Infra.Dados.Repositorios
{
    public class RepositorioItemEmprestado : RepositorioBase<ItemEmprestado>, IRepositorioItemEmprestado
    {
        public IEnumerable<ItemEmprestado> BuscaItensEmprestadosPorPessoa(int idPessoa)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemEmprestado> BustaItensEmprestadosPorLivro(int IdLivro)
        {
            throw new NotImplementedException();
        }
    }
}
