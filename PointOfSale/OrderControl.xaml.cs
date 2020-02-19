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
using CowboyCafe.Data; // pulling in CowboyCafe 

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            CowpokeChili.Click += AddCowPokeChiliButton; 
        }

        /// <summary>
        /// Creates new Cowpoke Chili  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowPokeChiliButton(object sender, EventArgs e)
        {
            OrderList.Items.Add(new CowpokeChili());
        }

        private void AddAngryChickenButton(object sender, EventArgs e)
        {
            OrderList.Items.Add(new CowpokeChili());
        }


    }
}
