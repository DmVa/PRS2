using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Db.Tables;

namespace Data.Db
{
    public class PresContext : DbContext
    {
        public DbSet<Login> Logins { get; set; }
    }
}
