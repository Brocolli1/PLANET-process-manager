using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using PrismApp.Models;
using PrismApp.ViewModels;

namespace PrismApp.Views
{
    /// <summary>
    /// Interaction logic for Processes
    /// </summary>
    public partial class Processes : UserControl
    {
        public Processes()
        {
            InitializeComponent();
        }


        public void Filter(object sender, TextChangedEventArgs textChangedEventArgs)
        {
            ProcessListBox.Items.Filter = (o) => ((ProcessInfo)o).Name.ToLower().Contains(FilterText.Text.ToLower()); 
        }

        public void OnClickStart(object sender, RoutedEventArgs e)
        {
            ProcessesViewModel.StartProcess(((ProcessInfo)ProcessListBox.SelectedItem).StartInfo);
        }

        public void OnClickKill(object sender, RoutedEventArgs e)
        {
            ProcessesViewModel.KillProcess(((ProcessInfo)ProcessListBox.SelectedItem).Id);
        }

        public void OnSortIdClick(object sender, RoutedEventArgs e)
        {
            ProcessListBox.Items.SortDescriptions.Clear();
            ProcessListBox.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Id", System.ComponentModel.ListSortDirection.Ascending));
        }

        public void OnSortNameClick(object sender, RoutedEventArgs e)
        {
            ProcessListBox.Items.SortDescriptions.Clear();
            ProcessListBox.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Name", System.ComponentModel.ListSortDirection.Ascending));
        }


        public void OnHigherPriorityClick(object sender, RoutedEventArgs e)
        {
            ProcessesViewModel.SetProcessPriorityToHigh(((ProcessInfo)ProcessListBox.SelectedItem).Id);
            ProcessListBox.Items.Refresh();
        }

        public void OnLowerPriorityClick(object sender, RoutedEventArgs e)
        {
            ProcessesViewModel.SetProcessPriorityToLow(((ProcessInfo)ProcessListBox.SelectedItem).Id);
            ProcessListBox.Items.Refresh();
        }
        
    }
}
