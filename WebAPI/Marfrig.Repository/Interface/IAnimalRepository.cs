using Marfrig.Domain;
using System.Threading.Tasks;

namespace Marfrig.Repository.Interface
{
    public interface IAnimalRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();

        Task<Animal[]> GetAllAnimalAsync();
        Task<Animal> GetAnimalAsyncById(int AnimalId);
    }
}
