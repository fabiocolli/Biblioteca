using Bibliteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliteca.Dominio.Interfaces
{
    public interface IRepositorioItemEmprestado : IRepositorioBase<ItemEmprestado>
    {
        IEnumerable<ItemEmprestado> BuscaItensEmprestadosPorPessoa(int idPessoa);
        IEnumerable<ItemEmprestado> BustaItensEmprestadosPorLivro(int IdLivro);
    }
}
