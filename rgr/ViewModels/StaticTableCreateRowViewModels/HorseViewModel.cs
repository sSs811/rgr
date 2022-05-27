using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgr.ViewModels.StaticTableCreateRowViewModels
{
    public class HorseViewModel : ViewModelBase
    {
        public HorseViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Horse = new rgr.Models.Database.Horse();
        }
        public rgr.Models.Database.Horse Horse { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
