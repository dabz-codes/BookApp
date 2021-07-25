using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Services.Repository
{
    //The angular bracket tells the interface that it is expecting something T which inherits a class
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression);

        //entity below is just a normal variable name. T there is just as we use datatype like string but R here is a class as inherited above.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
