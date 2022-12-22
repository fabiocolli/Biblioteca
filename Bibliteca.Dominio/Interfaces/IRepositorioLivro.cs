using Bibliteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliteca.Dominio.Interfaces
{
    public interface IRepositorioLivro : IRepositorioBase<Livro>
    {
        IEnumerable<Livro> BuscaPorTitulo(string tituloLivro);
        IEnumerable<Livro> BuscaPorAnoDeLancamento(int anoLancamento);
        IEnumerable<Livro> BUscaPorAutor(string nomeAutor);
    }
}
