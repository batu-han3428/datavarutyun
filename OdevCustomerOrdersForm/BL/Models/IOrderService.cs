using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public interface IOrderService
    {
        List<Order> sirketGetir(Expression<Func<Order ,bool>> filter = null);
    }
}
