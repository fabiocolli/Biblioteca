using Bibliteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliteca.Dominio.Interfaces
{
    public interface IRepositorioPessoa : IRepositorioBase<Pessoa>
    {
        IEnumerable<Pessoa> BuscarPorNome(string nomePessoa);
        IEnumerable<Pessoa> BuscarPessoasAtivas();
        IEnumerable<Pessoa> BuscarPessoaComAniversarioHoje();
    }
}
