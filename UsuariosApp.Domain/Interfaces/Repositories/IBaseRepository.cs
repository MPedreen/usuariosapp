namespace UsuariosApp.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TModel, TKey> : IDisposable
        where TModel : class
    {
        void Add(TModel model);
        void Update(TModel model);
        void Delete(TModel model);
        List<TModel> GetAll();
        List<TModel> GetAll(Func<TModel, bool> where);
        TModel Get(Func<TModel, bool> where);
        TModel GetById(TKey id);
    }
}