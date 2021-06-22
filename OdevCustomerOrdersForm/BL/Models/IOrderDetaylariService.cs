using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public interface IOrderDetaylariService
    {
        List<OrderDetail> sirketGetir(Expression<Func<OrderDetail ,bool>> filter = null);
    }
}
