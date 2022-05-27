using System;
using System.Collections.Generic;

namespace rgr.Models.Database
{
    public partial class Horse
    {
        public string NameHorse { get; set; } = null!;
        public long? Ves { get; set; }
        public string? Pol { get; set; }
        public long? Age { get; set; }
    }
}
