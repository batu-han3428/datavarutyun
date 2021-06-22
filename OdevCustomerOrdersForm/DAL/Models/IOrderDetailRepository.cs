using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public interface IOrderDetailRepository : IBaseRepository<OrderDetail>
    {
        List<OrderDetail> detaylarigetir(Expression<Func<OrderDetail, bool>> filter = null);
    }
}
