using SudokuVerify.Domain.Interfaces.Repositories;
using SudokuVerify.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SudokuVerify.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly BaseContext db;
        public RepositoryBase(BaseContext db)
        {
            this.db = db;
        }

        public TEntity Add(TEntity obj)
        {
            db.Set<TEntity>().Add(obj);
            db.SaveChanges();
            return obj;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> GetByFilter(Expression<Func<TEntity, bool>> filter)
        {
            return db.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity GetById(int id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            db.Set<TEntity>().Remove(obj);
            db.SaveChanges();
        }

        public virtual void Update(TEntity obj)
        {
            db.Set<TEntity>().Update(obj);
            db.SaveChanges();
        }
    }
}
