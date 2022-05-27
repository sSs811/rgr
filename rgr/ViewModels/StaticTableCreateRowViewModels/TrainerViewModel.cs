using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgr.ViewModels.StaticTableCreateRowViewModels
{
    public class TrainerViewModel : ViewModelBase
    {
        public TrainerViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Trainer = new rgr.Models.Database.Trainer();
        }
        public rgr.Models.Database.Trainer Trainer { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
