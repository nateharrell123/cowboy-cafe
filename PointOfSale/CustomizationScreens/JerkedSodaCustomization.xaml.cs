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

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for JerkedSodaCustomization.xaml
    /// </summary>
    public partial class JerkedSodaCustomization : UserControl
    {
        public JerkedSodaCustomization()
        {
            InitializeComponent();
            Sarsparilla.Checked += SarsparillaChecked;
            CreamSoda.Checked += CreamsodaChecked;
            OrangeSoda.Checked += OrangeSodaChecked;
            BirchBeer.Checked += BirchBeerChecked;
            RootBeer.Checked += RootBeerChecked;
        }

        /// <summary>
        /// Checks if Sarsparilla was checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void SarsparillaChecked(object sender, RoutedEventArgs arg)
        {
            if(DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.Sarsparilla;
            }
        }

        /// <summary>
        /// Checks if Cream Soda was checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void CreamsodaChecked(object sender, RoutedEventArgs arg)
        {
            if(DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.CreamSoda;
            }
        }

        /// <summary>
        /// Checks if Orange Soda was selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void OrangeSodaChecked(object sender, RoutedEventArgs arg)
        {
            if(DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.OrangeSoda;
            }
        }

        /// <summary>
        /// Checks if Birch Beer was clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void BirchBeerChecked(object sender, RoutedEventArgs arg)
        {
            if(DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.BirchBeer;
            }
        }

        /// <summary>
        /// Checks if Root Beer was chosen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void RootBeerChecked(object sender, RoutedEventArgs arg)
        {
            if(DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.RootBeer;
            }
        }
    }
}
