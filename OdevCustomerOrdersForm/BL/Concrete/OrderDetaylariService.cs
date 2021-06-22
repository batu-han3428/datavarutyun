using BL.Models;
using DAL.Models;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Concrete
{
    public class OrderDetaylariService : IOrderDetaylariService
    {
        private IOrderDetailRepository orderDetailRepository;
        public OrderDetaylariService(IOrderDetailRepository orderDetailRepository)
        {
            this.orderDetailRepository = orderDetailRepository;
        }

        public List<OrderDetail> sirketGetir(Expression<Func<OrderDetail, bool>> filter = null)
        {
            return orderDetailRepository.hepsiniGetir(filter);
        }
    }
}
