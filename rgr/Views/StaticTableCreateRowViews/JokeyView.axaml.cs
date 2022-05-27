using Avalonia;
using Avalonia.Interactivity;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using rgr.ViewModels;
using rgr.ViewModels.StaticTableCreateRowViewModels;

namespace rgr.Views.StaticTableCreateRowViews
{
    public partial class JokeyView : Window
    {
        public JokeyView()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.FindControl<Button>("Confirm").Click += button_Confirm_Click;
            this.FindControl<Button>("Cancel").Click += button_Cancel_Click;
        }
        public JokeyView(MainWindowViewModel? mainContext) : this()
        {
            this.DataContext = new JokeyViewModel(mainContext);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        private void button_Confirm_Click(object? sender, RoutedEventArgs e)
        {
            var dc = (this.DataContext as JokeyViewModel);
            dc.MainContext.Data.Jokeys.Add(dc.Jokey);
            dc.MainContext.Data.SaveChanges();
            this.Close();
        }
        private void button_Cancel_Click(object? sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
