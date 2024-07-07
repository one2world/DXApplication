using DevExpress.Mvvm;
using DXApplication2.Models;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DXApplication2.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<Customer> Source { get; set; }
        public IAsyncCommand AsyncAddCommand { get; }
        public IAsyncCommand AsyncRemoveCommand { get; }
        public MainViewModel()
        {
            Source = new CustomerDataModel().GetCustomers();
            AsyncAddCommand = new AsyncCommand(AsyncAddMethod);
            AsyncRemoveCommand = new AsyncCommand(AsyncRemoveMethod);
        }

        async Task AsyncAddMethod()
        {
            //while (!AsyncAddCommand.IsCancellationRequested)
            //{
            //}
            await Task.Delay(100);
            Source?.Add(new Customer() { Name = "New Person", City = "New City", Visits = 0, Birthday = DateTime.Now });
        }

        async Task AsyncRemoveMethod()
        {
            //while (!AsyncRemoveCommand.IsCancellationRequested)
            //{
            //}
            await Task.Delay(100);
            Source?.RemoveAt(Source.Count - 1);
        }
    }

}
