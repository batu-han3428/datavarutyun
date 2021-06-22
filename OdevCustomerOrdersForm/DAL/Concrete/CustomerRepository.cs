using DAL.Models;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
  
    }
}
