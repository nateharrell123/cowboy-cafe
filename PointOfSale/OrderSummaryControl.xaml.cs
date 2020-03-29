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
using CowboyCafe.Data;
using PointOfSale.CustomizationScreens;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// What happens when an item in the ListBox is selected (clicked on).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyOrder(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var item = OrderListBox.SelectedItem;
                CheckTypeAndLoadScreen(item);
            }
            catch (Exception)
            {
                Console.WriteLine("MAYDAY MAYDAY!! ABORT ABORT!!");
            }
        }

        private void RemoveItem(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order) // these feel redundent
            {
                if(sender is Button button)
                {
                    if(button.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }


        private void CheckTypeAndLoadScreen(object item) // too many if statements :-(
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (item is AngryChicken)
            {
                var screen = new AngryChickenCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if (item is BakedBeans)
            {
                var screen = new BakedBeansCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if (item is ChiliCheeseFries)
            {
                var screen = new ChiliCheeseFriesCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if (item is CornDodgers)
            {
                var screen = new CornDodgersCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if (item is CowboyCoffee)
            {
                var screen = new CowboyCoffeeCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if (item is CowpokeChili)
            {
                var screen = new CowPokeChiliCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if (item is DakotaDoubleBurger)
            {
                var screen = new DakotaDoubleBurgerCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if (item is JerkedSoda)
            {
                var screen = new JerkedSodaCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if (item is PanDeCampo)
            {
                var screen = new PanDeCampoCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if (item is PecosPulledPork)
            {
                var screen = new PecosPulledPorkCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if (item is TexasTea)
            {
                var screen = new TexasTeaCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if (item is TexasTripleBurger)
            {
                var screen = new TexasTripleBurgerCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            if (item is TrailBurger)
            {
                var screen = new TrailBurgerCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }
    }
}
