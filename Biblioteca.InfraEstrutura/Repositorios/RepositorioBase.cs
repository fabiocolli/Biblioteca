using Biblioteca.Infra.Dados.Contexto;
using Bibliteca.Dominio.Interfaces;
using System.Data.Entity;

namespace Biblioteca.Infra.Dados.Repositorios
{
    public class RepositorioBase<T> : IDisposable, IRepositorioBase<T> where T : class
    {
        protected BibliotecaContext _db = new BibliotecaContext();

        public void Atualiza(T objeto)
        {
            _db.Entry(objeto).State = EntityState.Modified;

            SalvarTudo();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Excluit(T objeto)
        {
            _db.Set<T>().Remove(objeto);
        }

        public void Incluir(T objeto)
        {
            _db.Set<T>().Add(objeto);
        }

        public T ListarPorId(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public IEnumerable<T> ListarTodos()
        {
            return _db.Set<T>().ToList();
        }

        public void SalvarTudo()
        {
            _db.SaveChanges();
        }
    }
}
