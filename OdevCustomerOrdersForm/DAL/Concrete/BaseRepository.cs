using DAL.Models;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class, new()
    {
        protected NorthwindDbContext northwindDbContext;

        public BaseRepository() 
        {
            this.northwindDbContext = new NorthwindDbContext();
        }
        public bool ekle(T model)
        {

            return true;
        }

        public bool guncelle(T model)
        {
            throw new NotImplementedException();
        }

        public List<T> hepsiniGetir(Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
            {
                return northwindDbContext.Set<T>().ToList();
            }
            else
            {
                return northwindDbContext.Set<T>().Where(filter).ToList();
            }
        }

        public T idGetir(int id)
        {
            throw new NotImplementedException();
        }

        public bool sil(T model)
        {
            throw new NotImplementedException();
        }
    }
}
