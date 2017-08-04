using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using VMVSite.Domain.Core;

namespace VMVSite.Infrastructure.Data
{
    public class VMVContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderProject> OrderProjects { get; set; }
    }
}
