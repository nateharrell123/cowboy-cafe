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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates new Cowpoke Chili object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowPokeChiliButton(object sender, EventArgs e)
        {
            if(DataContext is Order order)
            {
                order.Add(new CowpokeChili());
            }
        }

        /// <summary>
        /// Creates new Angry Chicken object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChickenButton(object sender, EventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new AngryChicken());
            }
        }

        /// <summary>
        /// Creates new Baked Beans object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeansButton(object sender, EventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new BakedBeans());
            }
        }

        /// <summary>
        /// Creates new Chili Cheese Fries object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFriesButton(object sender, EventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new ChiliCheeseFries());
            }
        }

        /// <summary>
        /// Creates new Corn Dodgers object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgersButton(object sender, EventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CornDodgers());
            }
        }

        /// <summary>
        /// Creates new Pan De Campo object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampoButton(object sender, EventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PanDeCampo());
            }
        }

        /// <summary>
        /// Creates a new Cowboy Coffee object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowBoyCoffeeButton(object sender, EventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CowboyCoffee());
            }
        }

        /// <summary>
        /// Creates a new Jerked Soda object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSodaButton(object sender, EventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new JerkedSoda());
            }
        }

        /// <summary>
        ///  Creates a new Texas Tea object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTeaButton(object sender, EventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTea());
            }
        }
        /// <summary>
        ///  Creates a new Water object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWaterButton(object sender, EventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new Water());
            }
        }

        /// <summary>
        ///  Creates a new Dakota Double Burger object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurgerButton(object sender, EventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new DakotaDoubleBurger());
            }
        }

        /// <summary>
        ///  Creates a new Pecos Pulled Pork object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPorkButton(object sender, EventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PecosPulledPork());
            }
        }

        /// <summary>
        ///  Creates a new Rustler's Ribs object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibsButton(object sender, EventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new RustlersRibs());
            }
        }

        /// <summary>
        ///  Creates a new Texas Triple Burger object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurgerButton(object sender, EventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTripleBurger());
            }
        }

        /// <summary>
        ///  Creates a new Trail Burger object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurgerButton(object sender, EventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TrailBurger());
            }
        }
    }
}
