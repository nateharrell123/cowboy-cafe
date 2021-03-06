﻿using System;
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
    /// Interaction logic for ChiliCheeseFriesCustomization.xaml
    /// </summary>
    public partial class ChiliCheeseFriesCustomization : UserControl
    {
        public ChiliCheeseFriesCustomization()
        {
            InitializeComponent();

            SmallButton.Checked += Small_Checked;
            MediumButton.Checked += Medium_Checked;
            LargeButton.Checked += Large_Checked;
        }
        /// <summary>
        /// If Small is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void Small_Checked(object sender, RoutedEventArgs arg)
        {
            if(DataContext is ChiliCheeseFries fries)
            {
                fries.Size = CowboyCafe.Data.Size.Small;
            }
        }
        /// <summary>
        /// If Medium is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void Medium_Checked(object sender, RoutedEventArgs arg)
        {
            if(DataContext is ChiliCheeseFries fries)
            {
                fries.Size = CowboyCafe.Data.Size.Medium;
            }
        }
        private void Large_Checked(object sender, RoutedEventArgs arg)
        {
            if(DataContext is ChiliCheeseFries fries)
            {
                fries.Size = CowboyCafe.Data.Size.Large;
            }
        }
    }
}
