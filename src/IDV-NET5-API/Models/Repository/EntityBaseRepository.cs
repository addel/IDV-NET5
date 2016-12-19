using Microsoft.AspNetCore.Mvc;
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

        public MyEntity GetSingle(int id)
        {
            return _context.Set<MyEntity>().FirstOrDefault(x => x.Id == id);
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

        public virtual void Commit()
        {
            _context.SaveChanges();
        }
    }
}
