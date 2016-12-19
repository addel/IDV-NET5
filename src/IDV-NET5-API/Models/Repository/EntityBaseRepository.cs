using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace IDV_NET5_API.Models.Repository
{
    public class EntityBaseRepository<MyEntity> : IEntityBaseRepository<MyEntity>
        where MyEntity : class, IEntityBase, new()
    {
        private APIdbContext _context;

        public EntityBaseRepository(APIdbContext context)
        {
            _context = context;
        }

        public virtual IEnumerable<MyEntity> GetAll()
        {
            return _context.Set<MyEntity>().AsEnumerable();
        }

        public virtual int Count()
        {
            return _context.Set<MyEntity>().Count();
        }
        public virtual IEnumerable<MyEntity> AllIncluding(params Expression<Func<MyEntity, object>>[] includeProperties)
        {
            IQueryable<MyEntity> query = _context.Set<MyEntity>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query.AsEnumerable();
        }

        public MyEntity GetSingle(int id)
        {
            return _context.Set<MyEntity>().FirstOrDefault(x => x.Id == id);
        }

        public MyEntity GetSingle(Expression<Func<MyEntity, bool>> predicate)
        {
            return _context.Set<MyEntity>().FirstOrDefault(predicate);
        }

        public MyEntity GetSingle(Expression<Func<MyEntity, bool>> predicate, params Expression<Func<MyEntity, object>>[] includeProperties)
        {
            IQueryable<MyEntity> query = _context.Set<MyEntity>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return query.Where(predicate).FirstOrDefault();
        }

        public virtual IEnumerable<MyEntity> FindBy(Expression<Func<MyEntity, bool>> predicate)
        {
            return _context.Set<MyEntity>().Where(predicate);
        }

        public virtual void Add(MyEntity entity)
        {
            EntityEntry dbEntityEntry = _context.Entry<MyEntity>(entity);
            _context.Set<MyEntity>().Add(entity);
        }

        public virtual void Update(MyEntity entity)
        {
            EntityEntry dbEntityEntry = _context.Entry<MyEntity>(entity);
            dbEntityEntry.State = EntityState.Modified;
        }
        public virtual void Delete(MyEntity entity)
        {
            EntityEntry dbEntityEntry = _context.Entry<MyEntity>(entity);
            dbEntityEntry.State = EntityState.Deleted;
        }

        public virtual void DeleteWhere(Expression<Func<MyEntity, bool>> predicate)
        {
            IEnumerable<MyEntity> entities = _context.Set<MyEntity>().Where(predicate);

            foreach (var entity in entities)
            {
                _context.Entry<MyEntity>(entity).State = EntityState.Deleted;
            }
        }

        public virtual void Commit()
        {
            _context.SaveChanges();
        }
    }
}
