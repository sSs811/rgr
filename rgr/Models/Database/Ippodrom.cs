using System;
using System.Collections.Generic;

namespace rgr.Models.Database
{
    public partial class Ippodrom
    {
        public Ippodrom()
        {
            Zabegs = new HashSet<Zabeg>();
        }

        public string Name { get; set; } = null!;
        public string? Pokritie { get; set; }

        public virtual ICollection<Zabeg> Zabegs { get; set; }
    }
}
