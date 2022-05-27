using System;
using System.Collections.Generic;

namespace rgr.Models.Database
{
    public partial class Trainer
    {
        public string? NameTrainer { get; set; }
        public string? NameHorse { get; set; }

        public virtual Horse? NameHorseNavigation { get; set; }
    }
}
