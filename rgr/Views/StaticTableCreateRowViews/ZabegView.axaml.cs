using Avalonia;
using Avalonia.Interactivity;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using rgr.ViewModels;
using rgr.ViewModels.StaticTableCreateRowViewModels;

namespace rgr.Views.StaticTableCreateRowViews
{
    public partial class ZabegView : Window
    {
        public ZabegView()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.FindControl<Button>("Confirm").Click += button_Confirm_Click;
            this.FindControl<Button>("Cancel").Click += button_Cancel_Click;
        }
        public ZabegView(MainWindowViewModel? mainContext) : this()
        {
            this.DataContext = new ZabegViewModel(mainContext);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        private void button_Confirm_Click(object? sender, RoutedEventArgs e)
        {
            var dc = (this.DataContext as ZabegViewModel);
            dc.MainContext.Data.Zabegs.Add(dc.Zabeg);
            dc.MainContext.Data.SaveChanges();
            this.Close();
        }
        private void button_Cancel_Click(object? sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
