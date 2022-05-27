using System;
using System.Collections.Generic;

namespace rgr.Models.Database
{
    public partial class Jokey
    {
        public string? NameJokey { get; set; }
        public string? NameHorse { get; set; }

        public virtual Horse? NameHorseNavigation { get; set; }
    }
}
