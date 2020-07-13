using System.Linq;
using System.Threading.Tasks;
using Marfrig.Domain;
using Marfrig.Repository.Context;
using Marfrig.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Marfrig.Repository.Repository
{
    public class CompraGadoItemRepository : ICompraGadoItemRepository
    {
        private readonly MarfrigContext _context;

        #region CONSTRUTOR
        public CompraGadoItemRepository(MarfrigContext context)
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
        //CompraGadoItem
        public async Task<CompraGadoItem[]> GetAllCompraGadoItemAsync(bool includePecuaristas = false)
        {
            IQueryable<CompraGadoItem> query = _context.CompraGadoitens
                .Include(c => c.Animal)
                .Include(c => c.CompraGado);

            if (includePecuaristas)
            {
                query = query
                    .Include(pe => pe.CompraGado)
                    .ThenInclude(p => p.Pecuarista);
            }

            query = query.AsNoTracking()
                        .OrderBy(c => c.Id);

            return await query.ToArrayAsync();
        }

        public async Task<CompraGadoItem> GetCompraGadoItemAsyncById(int CompraGadoItemId, bool include)
        {
            IQueryable<CompraGadoItem> query = _context.CompraGadoitens;
                

            if (include)
            {
                query = query
                    .Include(pe => pe.CompraGado)
                    .ThenInclude(p => p.Pecuarista)
                    .Include(c => c.Animal)
                    .Include(c => c.CompraGado);

            }

            query = query.AsNoTracking()
                        .OrderBy(c => c.Id)
                        .Where(c => c.Id == CompraGadoItemId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<CompraGadoItem[]> GetCompraGadoItemAsyncByPecuaristaId(int PecuaristaId)
        {
            IQueryable<CompraGadoItem> query = _context.CompraGadoitens
                .Include(c => c.Animal)
                .Include(c => c.CompraGado);
                
                query = query
                    .Include(pe => pe.CompraGado)
                    .ThenInclude(p => p.Pecuarista);

            

            query = query.AsNoTracking()
                        .OrderBy(c => c.Id)
                        .Where(c => c.CompraGado.Pecuarista.Id == PecuaristaId);

            return await query.ToArrayAsync();
        }
        #endregion
    }
}