namespace Bibliteca.Dominio.Interfaces
{
    public interface IRepositorioBase<T> where T : class
    {
        void Incluir(T objeto);
        T ListarPorId(int id);
        IEnumerable<T> ListarTodos();
        void Atualiza(T objeto);
        void Excluit(T objeto);
        void Dispose();
        void SalvarTudo();
    }
}
