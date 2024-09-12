using Microsoft.EntityFrameworkCore;
using Statistica_Fatturato_Vendite.Models;

namespace Statistica_Fatturato_Vendite.DataContext
{
    public class DataContextVeaGroup : DbContext
    {
        public DataContextVeaGroup(DbContextOptions<DataContextVeaGroup> options) : base(options)
        {
        }

        public DbSet<Item> Item { get; set; }
        public DbSet<ValueEntry> ValueEntry { get; set; }
        public DbSet<Customer> Customer { get; set; }


    }
}
