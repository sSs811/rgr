using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgr.ViewModels.StaticTableCreateRowViewModels
{
    public class OwnerViewModel : ViewModelBase
    {
        public OwnerViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Owner = new rgr.Models.Database.Owner();
        }
        public rgr.Models.Database.Owner Owner { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
