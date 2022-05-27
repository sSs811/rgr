using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rgr.Models.Database;

namespace rgr.Models.StaticTabs
{
    public class ResultTab : StaticTab
    {
        public ResultTab(DbSet<Result>? dBS = null)
        {
            Header = "Result";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("NameHorse");
            DataColumns.Add("Vid");
            DataColumns.Add("Start");
            DataColumns.Add("Finish");
            DataColumns.Add("Otstavanie");
 
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Result>? DBS { get; set; }
    }
}
