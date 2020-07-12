using Marfrig.Domain;
using Marfrig.Repository.Context;
using Marfrig.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Marfrig.Repository.Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly MarfrigContext _context;

        #region CONSTRUTOR
        public AnimalRepository(MarfrigContext context)
        {
            this._context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        #endregion

        #region CONSULTAS GERAIS
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
        #endregion       

        #region CONSULTAS ESPECIFICAS
        public async Task<Animal[]> GetAllAnimalAsync()
        {
            IQueryable<Animal> query = _context.Animals;

            query = query.AsNoTracking()
                        .OrderBy(c => c.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Animal> GetAnimalAsyncById(int AnimalId)
        {
            IQueryable<Animal> query = _context.Animals;

            query = query.AsNoTracking()
                        .OrderBy(c => c.Id)
                        .Where(c => c.Id == AnimalId);

            return await query.FirstOrDefaultAsync();
        }

        #endregion
    }
}
