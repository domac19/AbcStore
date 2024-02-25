using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AbcStore.Data
{
    public class AbcStoreContext : DbContext
    {
        public AbcStoreContext() : base("name=AbcStoreContext")
        {
        }

        public System.Data.Entity.DbSet<AbcStore.Models.Article> Articles { get; set; }
        public System.Data.Entity.DbSet<AbcStore.Models.Person> Person { get; set; }
        public System.Data.Entity.DbSet<AbcStore.Models.Persons> Persons { get; set; }
    }
}
