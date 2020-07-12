using System.Threading.Tasks;
using Marfrig.Domain;

namespace Marfrig.Repository.Interface
{
    public interface ICompraGadoRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();

        Task<CompraGado[]> GetAllCompraGadoAsync(bool includePecuaristas);
        Task<CompraGado> GetCompraGadoAsyncById(int CompraGadoId, bool includePecuaristas);
    }
}