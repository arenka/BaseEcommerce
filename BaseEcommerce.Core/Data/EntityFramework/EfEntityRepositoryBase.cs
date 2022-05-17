using BaseEcommerce.Core.Data;
using BaseEcommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Core.Data.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
                                                                                   where TContext : DbContext, new()
    {



        public void Add(TEntity entity)
        {
            using (var _context = new TContext())
            {
                var addedEntity = _context.Entry(entity);
                addedEntity.State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var _context = new TContext())
            {
                var deletedntity = _context.Entry(entity);
                deletedntity.State = EntityState.Deleted;
                _context.SaveChanges();
            }

        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var _context = new TContext())
            {
                var entity = _context.Set<TEntity>().FirstOrDefault(filter);
                return entity == null ? null : entity;
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var _context = new TContext())
            {
                return filter == null ? _context.Set<TEntity>().ToList()
                                 : _context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var _context = new TContext())
            {
                var updatedEntity = _context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                _context.SaveChanges();
            }

        }
    }
}
