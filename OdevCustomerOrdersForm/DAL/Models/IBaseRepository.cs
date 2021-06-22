using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public interface IBaseRepository<T>
        where T:class, new()
    {
        List<T> hepsiniGetir(Expression<Func<T, bool>> filter = null);
        T idGetir(int id);
        bool guncelle(T model);
        bool sil(T model);
        bool ekle(T model);

    }
}
