using Biblioteca.Domain.Shared.Repositories.Interface;
using Biblioteca.Infra.SqlServer.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra.SqlServer.EF.Repositories.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly BaseContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(BaseContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual bool CheckByFunc(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate)?.Count() > 0;
        }

        public virtual void Add(TEntity t)
        {
            DbSet.Add(t);
        }

        public virtual EntityEntry AddEntity(TEntity t)
        {
            return DbSet.Add(t);
        }

        public virtual void Delete(object key)
        {
            var entry = DbSet.Find(key);

            DbSet.Remove(entry);
        }

        public virtual void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public virtual void DeleteList(List<TEntity> entities)
        {
            entities.ForEach(e => Delete(e));
        }

        public void Update(TEntity t)
        {
            DbSet.Update(t);
        }

        public virtual async Task<TEntity> UpdateAsyn(TEntity t, object key)
        {
            if (t == null)
                return null;
            TEntity exist = await DbSet.FindAsync(key);
            if (exist != null)
            {
                Db.Entry(exist).CurrentValues.SetValues(t);
            }
            return exist;
        }

        public virtual void Save()
        {
        }

        public virtual async Task SaveAsync(TEntity t)
        {
            Db.Entry(t).State = EntityState.Modified;
            await Db.SaveChangesAsync();
        }

        public async virtual Task<int> SaveAsync()
        {
            return await Db.SaveChangesAsync();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
