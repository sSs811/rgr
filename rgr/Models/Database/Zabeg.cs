using System;
using System.Collections.Generic;

namespace rgr.Models.Database
{
    public partial class Zabeg
    {
        public string Vid { get; set; } = null!;
        public byte[]? Data { get; set; }
        public string? Dist { get; set; }
        public string? Ippodrom { get; set; }

        public virtual Ippodrom? IppodromNavigation { get; set; }
    }
}
