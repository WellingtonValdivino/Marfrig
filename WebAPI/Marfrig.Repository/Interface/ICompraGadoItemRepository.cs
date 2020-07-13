using System.Threading.Tasks;
using Marfrig.Domain;

namespace Marfrig.Repository.Interface
{
    public interface ICompraGadoItemRepository
    {
         void Add<T>(T entity) where T: class;
         void Update<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;

         Task<bool> SaveChangesAsync();

        //CompraGadoItem
        Task<CompraGadoItem[]> GetAllCompraGadoItemAsync(bool includeCompraGadoItem);
        Task<CompraGadoItem> GetCompraGadoItemAsyncById(int CompraGadoItemId, bool include);

        Task<CompraGadoItem[]> GetCompraGadoItemAsyncByPecuaristaId(int PecuaristaIdId);
    }
}