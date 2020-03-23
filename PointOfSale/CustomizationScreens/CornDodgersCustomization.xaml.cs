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
    /// Interaction logic for CornDodgersCustomization.xaml
    /// </summary>
    public partial class CornDodgersCustomization : UserControl
    {
        public CornDodgersCustomization()
        {
            InitializeComponent();

            SmallButton.Checked += Small_Checked;
            MediumButton.Checked += Medium_Checked;
            LargeButton.Checked += Large_Checked;
        }

        private void Small_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is CornDodgers corn)
            {
                corn.Size = CowboyCafe.Data.Size.Small;
            }
        }
        /// <summary>
        /// If Medium is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void Medium_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is CornDodgers corn)
            {
                corn.Size = CowboyCafe.Data.Size.Medium;
            }
        }
        /// <summary>
        /// If Large is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void Large_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is CornDodgers corn)
            {
                corn.Size = CowboyCafe.Data.Size.Large;
            }
        }
    }
}
