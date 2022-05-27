using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgr.ViewModels.StaticTableCreateRowViewModels
{
    public class IppodromViewModel : ViewModelBase
    {
        public IppodromViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Ippodrom = new rgr.Models.Database.Ippodrom();
        }
        public rgr.Models.Database.Ippodrom Ippodrom { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
