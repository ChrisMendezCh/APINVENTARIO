using Microsoft.AspNetCore.Authentication;
using System.Collections.Generic;

namespace APINVENTARIO_BACKED.data
{
    public class DataContext : Dbcontext
    {
            public DataContext(DbContextOptions<DataContext>options) : base(options) { }
        public ISet<Rol> Roles { get; set; }
        protected override void OnModelCreating(modelbuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            Roles = new ISet<Rol>();
        }
    }
}
