using AbcStore.Models;
using System.Data.Entity;

namespace AbcStore.Data
{
    public class AbcStoreContext : DbContext
    {
        public AbcStoreContext() : base("name=AbcStoreContext")
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Persons> Persons { get; set; }
    }
}
