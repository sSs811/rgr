using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgr.ViewModels.StaticTableCreateRowViewModels
{
    public class JokeyViewModel : ViewModelBase
    {
        public JokeyViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Jokey = new rgr.Models.Database.Jokey();
        }
        public rgr.Models.Database.Jokey Jokey { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
