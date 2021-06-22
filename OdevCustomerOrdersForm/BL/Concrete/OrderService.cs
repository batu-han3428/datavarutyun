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
    public class OrderService : IOrderService
    {
        private IOrderRepository orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public List<Order> sirketGetir(Expression<Func<Order, bool>> filter = null)
        {
            return orderRepository.hepsiniGetir(filter);
        }
    }
}
