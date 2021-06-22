using DAL.Models;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
    {
        public List<OrderDetail> detaylarigetir(Expression<Func<OrderDetail, bool>> filter = null)
        {
            if (filter == null)
            {
                return northwindDbContext.Set<OrderDetail>().ToList();
            }
            else
            {
                return northwindDbContext.Set<OrderDetail>().Include(odet => odet.Product).Where(filter).ToList();
            }
        }
    }
}
