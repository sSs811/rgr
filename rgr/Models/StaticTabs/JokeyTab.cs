using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rgr.Models.Database;

namespace rgr.Models.StaticTabs
{
    public class JokeyTab : StaticTab
    {
        public JokeyTab(DbSet<Jokey>? dBS = null)
        {
            Header = "Jokey";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("NameJokey");
            DataColumns.Add("NameHorse");
 
            ObjectList = DBS?.ToList<object>();
        }

        new public DbSet<Jokey>? DBS { get; set; }
    }
}
