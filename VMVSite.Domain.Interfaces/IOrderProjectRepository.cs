using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMVSite.Domain.Core;

namespace VMVSite.Domain.Interfaces
{
    public interface IOrderProjectRepository : IDisposable
    {
        IEnumerable<OrderProject> GetOrderProjectList();
        OrderProject GetOrderProject(int id);
        void Create(OrderProject item);
        void Update(OrderProject item);
        void Delete(int id);
        void Save();
    }
}
