using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rgr.Models.Database;

namespace rgr.Models.StaticTabs
{
    public class IppodromTab : StaticTab
    {
        public IppodromTab(DbSet<Ippodrom>? dBS = null)
        {
            Header = "Ippodrom";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Name");
            DataColumns.Add("Pokritie");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Ippodrom>? DBS { get; set; }
    }
}
