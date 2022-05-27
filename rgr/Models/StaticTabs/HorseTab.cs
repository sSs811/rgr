using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rgr.Models.Database;

namespace rgr.Models.StaticTabs
{
    public class HorseTab : StaticTab
    {
        public HorseTab(DbSet<Horse>? dBS = null)
        {
            Header = "Horse";
            DBS = dBS;
            DataColumns = new List<string>();

            DataColumns.Add("NameHorse");
            DataColumns.Add("Ves");
            DataColumns.Add("Pol");
            DataColumns.Add("Age");

            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Horse>? DBS { get; set; }
    }
}
