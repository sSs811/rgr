﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgr.Models
{
    public class Query
    {
        public Query(string n = "", string d = "", DynamicTab? bd = null)
        {
            Name = n;
            Description = d;
            BindedTab = bd;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public DynamicTab? BindedTab { get; set; }
    }
}
