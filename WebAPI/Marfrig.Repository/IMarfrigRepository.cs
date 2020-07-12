using System.Threading.Tasks;
using Marfrig.Domain;

namespace Marfrig.Repository
{
    public interface IMarfrigRepository
    {
         void Add<T>(T entity) where T: class;
         void Update<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;

         Task<bool> SaveChangesAsync();

         //CompraGadoItem
         Task<CompraGadoItem[]> GetAllCompraGadoItemAsync(bool includeCompraGadoItem);
         Task<CompraGadoItem> GetCompraGadoItemAsyncById(int CompraGadoItemId, bool includeCompraGadoItem);

         //CompraGado
         Task<CompraGado[]> GetAllCompraGadoAsync(bool includeEventos);
         Task<CompraGado> GetCompraGadoAsyncById(int PalestranteId, bool includeEventos);
    }
}