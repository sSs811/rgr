using Avalonia;
using Avalonia.Interactivity;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using rgr.Models;
using rgr.Models.StaticTabs;
using Microsoft.EntityFrameworkCore;
using rgr.ViewModels;
using rgr.ViewModels.StaticTableCreateRowViewModels;
using rgr.Views.StaticTableCreateRowViews;
using rgr.Models.Database;

namespace rgr.Views
{
    public partial class FirstView : UserControl
    {
        public FirstView()
        {
            InitializeComponent();
            this.Find<DataGrid>("DataTable").AutoGeneratingColumn += dataGrid_AutoGeneratingColumn;
            this.Find<DataGrid>("DataTable").PropertyChanged += dataGrid_PropertyChanged;
            this.FindControl<TabControl>("DataTabs").SelectionChanged += tabControl_SelectionChanged;
            this.FindControl<Button>("CreateNew").Click += button_CreateNew_Click;
            this.FindControl<Button>("Delete").Click += button_Delete_Click;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        private void changeDataGridItems()
        {
            object? selectedTab;
            selectedTab = this.FindControl<TabControl>("DataTabs").SelectedItem;
            if (selectedTab != null)
            {
                if (selectedTab is DynamicTab)
                {
                    var selectedItems = (selectedTab as DynamicTab).ObjectList;
                    if (selectedItems != null)
                        this.Find<DataGrid>("DataTable").Items = selectedItems;
                }
                else
                {
                    
                     if (selectedTab is ResultTab)
                    {
                        var selectedItems = (selectedTab as ResultTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is HorseTab)
                    {
                        var selectedItems = (selectedTab as HorseTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is JokeyTab)
                    {
                        var selectedItems = (selectedTab as JokeyTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is ZabegTab)
                    {
                        var selectedItems = (selectedTab as ZabegTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is IppodromTab)
                    {
                        var selectedItems = (selectedTab as IppodromTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is OwnerTab)
                    {
                        var selectedItems = (selectedTab as OwnerTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is TrainerTab)
                    {
                        var selectedItems = (selectedTab as TrainerTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                   
                    else throw new System.ArgumentException();
                }
            }
        }
        private void refreshDataGridItems()
        {
            this.Find<DataGrid>("DataTable").Items = null;
            changeDataGridItems();
        }
        private void tabControl_SelectionChanged(object? sender,
           SelectionChangedEventArgs e)
        {
            changeDataGridItems();
        }
        private void dataGrid_AutoGeneratingColumn(object? sender,
        DataGridAutoGeneratingColumnEventArgs e)
        {
            var tab = (this.FindControl<TabControl>("DataTabs").SelectedItem as MyTab);
            if (tab is DynamicTab) (this.DataContext as FirstViewModel).ButtonsEnabled = false;
            else (this.DataContext as FirstViewModel).ButtonsEnabled = true;
            if (!tab.DataColumns.Contains(e.Column.Header.ToString()))
                e.Column.IsVisible = false;
        }
        private void dataGrid_PropertyChanged(object? sender, AvaloniaPropertyChangedEventArgs e)
        {
            if (this.DataContext is not null)
                if (this.FindControl<TabControl>("DataTabs").SelectedItem is not DynamicTab)
                    (this.DataContext as FirstViewModel).MainContext.Data.SaveChanges();
        }

        async private void button_CreateNew_Click(object? sender, RoutedEventArgs e)
        {
            object? selectedTab;
            selectedTab = this.FindControl<TabControl>("DataTabs").SelectedItem;
            Window window;
            if (selectedTab != null)
            {
                 if (selectedTab is ResultTab)
                {
                    window = new ResultView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is HorseTab)
                {
                    window = new HorseView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is JokeyTab)
                {
                    window = new JokeyView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is ZabegTab)
                {
                    window = new ZabegView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is IppodromTab)
                {
                    window = new IppodromView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is OwnerTab)
                {
                    window = new OwnerView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is TrainerTab)
                {
                    window = new TrainerView((this.DataContext as FirstViewModel).MainContext);
                }
                
                else throw new System.ArgumentException();
                await window.ShowDialog((Window)this.VisualRoot);
                refreshDataGridItems();
            }
        }
        private void button_Delete_Click(object? sender, RoutedEventArgs e)
        {
            object? selectedTab;
            selectedTab = this.FindControl<TabControl>("DataTabs").SelectedItem;
            var dgItem = this.Find<DataGrid>("DataTable").SelectedItem;
            if (selectedTab != null && dgItem != null)
            {
                
                 if (selectedTab is ResultTab)
                {

                    (selectedTab as ResultTab).DBS.Remove(dgItem as Result);
                }
                else if (selectedTab is HorseTab)
                {

                    (selectedTab as HorseTab).DBS.Remove(dgItem as Horse);
                }
                else if (selectedTab is JokeyTab)
                {

                    (selectedTab as JokeyTab).DBS.Remove(dgItem as Jokey);
                }
                else if (selectedTab is ZabegTab)
                {

                    (selectedTab as ZabegTab).DBS.Remove(dgItem as Zabeg);
                }
                else if (selectedTab is IppodromTab)
                {

                    (selectedTab as IppodromTab).DBS.Remove(dgItem as Ippodrom);
                }
                else if (selectedTab is OwnerTab)
                {

                    (selectedTab as OwnerTab).DBS.Remove(dgItem as Owner);
                }
                else if (selectedTab is TrainerTab)
                {

                    (selectedTab as TrainerTab).DBS.Remove(dgItem as Trainer);
                }
                
                else throw new System.ArgumentException();
                (this.DataContext as FirstViewModel).MainContext.Data.SaveChanges();
                refreshDataGridItems();
            }
        }
    }
}