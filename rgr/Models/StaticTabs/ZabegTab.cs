using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rgr.Models.Database;

namespace rgr.Models.StaticTabs
{
    public class ZabegTab : StaticTab
    {
        public ZabegTab(DbSet<Zabeg>? dBS = null)
        {
            Header = "Zabeg";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Vid");
            DataColumns.Add("Data");
            DataColumns.Add("Dist");
            DataColumns.Add("Ippodrom");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Zabeg>? DBS { get; set; }
    }
}
