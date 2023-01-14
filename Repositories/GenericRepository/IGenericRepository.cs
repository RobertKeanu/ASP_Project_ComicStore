using ASP_Project.Models.Base;

namespace ASP_Project.Repositories.GenericRepository
{
    public interface IGenericRepository <TEntity> where TEntity : BaseEntity
    {
        // get all data
        //IAsyncEnumerable<TEntity> GetAll();
        IQueryable<TEntity> GetAllAsQueryable();

        // create
        Task CreateAsync(TEntity entity);
        void CreateRange(IEnumerable<TEntity> entities);
        Task CreateRangeAsync(IEnumerable<TEntity> entities);

        // update
        //void Update(TEntity entity);
        //void UpdateRange(IEnumerable<TEntity> entities);

        // delete
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);

        // find 
        //TEntity FindById(Guid id);
        Task<TEntity?> FindByIdAsync(Guid id);

        IAsyncEnumerable<TEntity> GetAsync();

        // save
        bool Save();
        Task<bool> SaveAsync();
    }
}
