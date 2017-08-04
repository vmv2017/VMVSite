using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMVSite.Domain.Core;

namespace VMVSite.Domain.Interfaces
{
    public interface ICustomerRepository : IDisposable
    {
        IEnumerable<Customer> GetCustomerLIst();
        Customer GetCustomer(int id);
        void Create(Customer item);
        void Update(Customer item);
        void Delete(int id);
        void Save();
    }
}
