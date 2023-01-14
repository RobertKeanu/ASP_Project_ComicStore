using ASP_Project.Data;
using ASP_Project.Models.Base;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ASP_Project.Repositories.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DataBaseContext _DataBaseContext; // why nullable?
        protected readonly DbSet<TEntity> _table;

        public GenericRepository(DataBaseContext context)
        {
            _DataBaseContext = context;
            _table = _DataBaseContext.Set<TEntity>();
        }
        
        public async Task<List<TEntity>> GetAll()
        {
            return await _table.AsNoTracking().ToListAsync();
        }

        public IQueryable<TEntity> GetAllAsQueryable()
        {
            return _table.AsNoTracking();
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
        }

/*        public void Create(TEntity entity)
        {
            _table.Add(entity);
        }
*/
        public void CreateRange(IEnumerable<TEntity> entities)
        {
            _table.AddRange(entities);
        }

        public async Task<TEntity?> FindByIdAsync(Guid id)
        {
            return await _table.FindAsync(id);
        }

        public async Task CreateRangeAsync(IEnumerable<TEntity> entities)
        {
            await _table.AddRangeAsync(entities);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _table.UpdateRange(entities);
        }

        public void Delete(TEntity entity)
        {
            _table.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _table.RemoveRange(entities);
        }

   /*     public TEntity FindById(Guid id)
        {
            return _table.Find(id);
        }
*/

        public bool Save()
        {
            try
            {
                return _DataBaseContext.SaveChanges() > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            return false;
        }

        public async Task<bool> SaveAsync()
        {
            try
            {
                return await _DataBaseContext.SaveChangesAsync() > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            return false;
        }
        public async IAsyncEnumerable<TEntity> GetAsync()
        {
            var location = await _table.AsNoTracking().ToListAsync();

            foreach (var entity in location)
            {
                yield return entity;
            }
        }
    }
}
