using CowboyCafe.Data;
using PointOfSale.TransactionHandling;
using System;
using System.Collections.Generic;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        public TransactionControl()
        {
            InitializeComponent();
        }

        private void CashClicked(object sender, RoutedEventArgs e)
        {
            var screen = new DollarControl();
            
        }

        private void CardClicked(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Hey");
        }
        private void CancelClicked(object sender, RoutedEventArgs e)
        {
            this.Content = new OrderControl();
        }
    }
}
