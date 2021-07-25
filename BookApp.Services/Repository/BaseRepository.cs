using BookApp.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace BookApp.Services.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly AppDbContext dbContext;

        public BaseRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(T entity) => dbContext.Set<T>().Add(entity);

        public void Delete(T entity) => dbContext.Set<T>().Remove(entity);        

        public IQueryable<T> GetAll() => dbContext.Set<T>();

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression) => dbContext.Set<T>().Where(expression);

        public void Update(T entity) => dbContext.Set<T>().Update(entity);
    }
}
