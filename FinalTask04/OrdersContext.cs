using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FinalTask4
{
    public class OrdersContext : DbContext
    {
        public OrdersContext() : base("Orders")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrdersContext>());
        }
        public DbSet<Model.Order> Orders { get; set; }
    }
}