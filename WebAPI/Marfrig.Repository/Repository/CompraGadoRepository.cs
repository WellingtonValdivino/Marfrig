using Marfrig.Domain;
using Marfrig.Repository.Context;
using Marfrig.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marfrig.Repository.Repository
{
    public class CompraGadoRepository :  ICompraGadoRepository
    {
        private readonly MarfrigContext _context;

        #region CONSTRUTOR
        public CompraGadoRepository(MarfrigContext context)
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
        public async Task<CompraGado[]> GetAllCompraGadoAsync(bool includePecuarista = false)
        {
            IQueryable<CompraGado> query = _context.CompraGados;

            if (includePecuarista)
            {
                query = query.Include(pe => pe.Pecuarista);
            }

            return await query.ToArrayAsync();
        }

        public async Task<CompraGado> GetCompraGadoAsyncById(int CompraGadoId, bool includePecuarista = false)
        {
            IQueryable<CompraGado> query = _context.CompraGados;

            if (includePecuarista)
            {
                query = query.Include(pe => pe.Pecuarista);
            }

            query = query.OrderBy(p => p.Id)
                        .Where(p => p.Id == CompraGadoId);

            return await query.FirstOrDefaultAsync();
        }

        #endregion
    }
}