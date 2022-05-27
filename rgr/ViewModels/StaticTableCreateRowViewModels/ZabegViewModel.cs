using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgr.ViewModels.StaticTableCreateRowViewModels
{
    public class ZabegViewModel : ViewModelBase
    {
        public ZabegViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Zabeg = new rgr.Models.Database.Zabeg();
        }
        public rgr.Models.Database.Zabeg Zabeg { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
