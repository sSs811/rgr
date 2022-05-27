using System;
using System.Collections.Generic;

namespace rgr.Models.Database
{
    public partial class Result
    {
        public string? NameHorse { get; set; }
        public string? Vid { get; set; }
        public long? Start { get; set; }
        public string? Finish { get; set; }
        public string? Otstavanie { get; set; }

        public virtual Horse? NameHorseNavigation { get; set; }
        public virtual Zabeg? VidNavigation { get; set; }
    }
}
