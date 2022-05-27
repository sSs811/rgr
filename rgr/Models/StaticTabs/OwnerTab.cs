using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rgr.Models.Database;

namespace rgr.Models.StaticTabs
{
    public class OwnerTab : StaticTab
    {
        public OwnerTab(DbSet<Owner>? dBS = null)
        {
            Header = "Owner";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("NameOwner");
            DataColumns.Add("NameHorse");

            ObjectList = DBS?.ToList<object>();
        }

        new public DbSet<Owner>? DBS { get; set; }
    }
}
