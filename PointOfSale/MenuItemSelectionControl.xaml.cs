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
using CowboyCafe;

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
            var orderControl = this.FindAncestor<OrderControl>(); // trying to find an OrderControl. if not, returns null
            if(DataContext is Order order)
            {
                if(sender is Button button)
                {
                    switch(button.Tag)
                    {
                        case "CowpokeChili":
                            var item = new CowpokeChili();
                            var screen = new CowPokeChiliCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Creates new Angry Chicken object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChickenButton(object sender, EventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if(sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "AngryChicken":
                            var item = new AngryChicken();
                            var screen = new AngryChickenCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Creates new Baked Beans object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeansButton(object sender, EventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "BakedBeans":
                            var item = new BakedBeans();
                            var screen = new BakedBeansCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Creates new Chili Cheese Fries object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFriesButton(object sender, EventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "ChiliCheeseFries":
                            var item = new ChiliCheeseFries();
                            var screen = new ChiliCheeseFriesCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Creates new Corn Dodgers object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgersButton(object sender, EventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CornDodgers":
                            var item = new CornDodgers();
                            var screen = new CornDodgersCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Creates new Pan De Campo object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampoButton(object sender, EventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "PanDeCampo":
                            var item = new PanDeCampo();
                            var screen = new PanDeCampoCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Creates a new Cowboy Coffee object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowBoyCoffeeButton(object sender, EventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CowboyCoffee":
                            var item = new CowboyCoffee();
                            var screen = new CowboyCoffeeCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Creates a new Jerked Soda object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSodaButton(object sender, EventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "JerkedSoda":
                            var item = new JerkedSoda();
                            var screen = new JerkedSodaCustomization();
                            screen.DataContext = item;
                            order.Add(item); // TODO: This needs to change flavors!
                            orderControl?.SwapScreen(screen);
                            break;
                    }
                }
            }
        }

        /// <summary>
        ///  Creates a new Texas Tea object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTeaButton(object sender, EventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "TexasTea":
                            var item = new TexasTea();
                            var screen = new TexasTeaCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                    }
                }
            }
        }
        /// <summary>
        ///  Creates a new Water object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWaterButton(object sender, EventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "Water":
                            var item = new Water();
                            var screen = new WaterCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                    }
                }
            }
        }

        /// <summary>
        ///  Creates a new Dakota Double Burger object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurgerButton(object sender, EventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "DakotaDoubleBurger":
                            var item = new DakotaDoubleBurger();
                            var screen = new DakotaDoubleBurgerCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                    }
                }
            }
        }

        /// <summary>
        ///  Creates a new Pecos Pulled Pork object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPorkButton(object sender, EventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            
            if(DataContext is Order order)
            {
                if(sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "PecosPulledPork":
                            var item = new PecosPulledPork();
                            var screen = new PecosPulledPorkCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                    }
                }
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
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "TexasTripleBurger":
                            var item = new TexasTripleBurger();
                            var screen = new TexasTripleBurgerCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                    }
                }

            }
        }

        /// <summary>
        ///  Creates a new Trail Burger object and adds it to the Order List Checked List Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurgerButton(object sender, EventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if(DataContext is Order order)
            {
                if(sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "TrailBurger":
                            var item = new TrailBurger();
                            var screen = new TrailBurgerCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                    }
                }
            }
        }
    }
}
