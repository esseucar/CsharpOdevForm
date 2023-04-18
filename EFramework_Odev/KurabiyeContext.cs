using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFramework
{
    public class KurabiyeContext:DbContext
    {
        public DbSet<Urun> kurabiye { get; set; }
    }
}
