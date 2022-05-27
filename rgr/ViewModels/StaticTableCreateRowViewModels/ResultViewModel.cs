using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgr.ViewModels.StaticTableCreateRowViewModels
{
    public class ResultViewModel : ViewModelBase
    {
        public ResultViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Result = new rgr.Models.Database.Result();
        }
        public rgr.Models.Database.Result Result { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
