using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SudokuVerify.Domain.Interface.Repository;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SudokuVerify.Infra
{
    public class BaseRepository<T> : IRepositoryBase<T> where T : class
    {
        #region Variables

        /// <summary>
        /// The context.
        /// </summary>
        protected readonly BaseContext _context;

        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository{T}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public BaseRepository(BaseContext context)
            : base()
        {
            this._context = context;
        }

        #endregion

        #region Methods
        
        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }
       
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public IEnumerable<T> GetByFilter(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();
        }
       
        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);             
        }       

        #endregion
    }
}
