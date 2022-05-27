﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using System.Reactive;
using rgr.Models;

namespace rgr.ViewModels
{
    public class SecondViewModel : ViewModelBase
    {
        public SecondViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            ButtonDeleteQuery = ReactiveCommand.Create<Query, Unit>((query) =>
            {
                MainContext.Queries.Remove(query);
                MainContext.Tabs.Remove(query.BindedTab);
                if (QueryDescription == query.Description)
                    QueryDescription = "";
                return Unit.Default;
            });
            ButtonShowQuery = ReactiveCommand.Create<Query, Unit>((query) =>
            {
                QueryDescription = query.Description;
                return Unit.Default;
            });
        }
        string queryDescription = "";
        public string QueryDescription
        {
            get { return queryDescription; }
            set { this.RaiseAndSetIfChanged(ref queryDescription, value); }
        }
        public ReactiveCommand<Query, Unit> ButtonDeleteQuery { get; }
        public ReactiveCommand<Query, Unit> ButtonShowQuery { get; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
