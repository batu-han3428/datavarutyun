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
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public List<Customer> sirketGetir(Expression<Func<Customer, bool>> filter = null)
        {
            return customerRepository.hepsiniGetir(filter);
        }
    }
}
