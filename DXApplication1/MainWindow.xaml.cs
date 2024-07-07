using DevExpress.Xpf.Core;
using DXApplication2.Models;
using DXApplication2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DXApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        private MainViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new MainViewModel();
            this.DataContext = viewModel;
        }

        private void OnDragRecordOver(object sender, DragRecordOverEventArgs e)
        {
            if (!e.IsFromOutside && typeof(Customer).IsAssignableFrom(e.GetRecordType()))
            {
                e.Effects = DragDropEffects.Move;
                e.Handled = true;
            }
        }

        private void OnDrop(object sender, DragEventArgs e)
        {
            //Customer data = (RecordDragDropData)e.Data.GetData(typeof(Customer));
            //var newRecords = data.Records.OfType<Customer>().Select(x => new Customer { Id = x.Id, Name = x.Name }).ToArray();
            //if (newRecords.Length > 0)
            //{
            //    DataObject dataObject = new DataObject();
            //    dataObject.SetData(new RecordDragDropData(newRecords));
            //}
        }

        private void OnDropRecord(object sender, DropRecordEventArgs e)
        {
            object data = e.Data.GetData(typeof(RecordDragDropData));
            if (!e.IsFromOutside)
            {
                foreach (Customer sourceItem in ((RecordDragDropData)data).Records)
                {
                    ((Customer)e.TargetRecord).Visits += sourceItem.Visits;
                }
            }
            //foreach (Customer sourceItem in ((RecordDragDropData)data).Records)
            //{
            //    ((Customer)e.Source).Visits -= sourceItem.Visits;
            //}
        }
    }
}
