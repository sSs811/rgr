using System;
using System.Collections.Generic;

namespace rgr.Models.Database
{
    public partial class Owner
    {
        public string? NameOwner { get; set; }
        public string? NameHorse { get; set; }

        public virtual Horse? NameHorseNavigation { get; set; }
    }
}
