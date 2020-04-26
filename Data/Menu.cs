using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// List of Entree items.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>()
            {
                new AngryChicken(),
                new CowpokeChili(),
                new DakotaDoubleBurger(),
                new PecosPulledPork(),
                new RustlersRibs(),
                new TexasTripleBurger(),
                new TrailBurger()
            };
            return entrees;
        }
        
        public static IEnumerable<IOrderItem> EntreeList { get { return Entrees(); } }

        /// <summary>
        /// List of Sides.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>()
            {
                new BakedBeans(),
                new ChiliCheeseFries(),
                new CornDodgers(),
                new PanDeCampo(),
            };
            return sides;
        }

        public static IEnumerable<IOrderItem> SidesList { get { return Sides(); } }

        /// <summary>
        /// List of drinks
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>()
            {
                new JerkedSoda(),
                new TexasTea(),
                new Water()
            };

            return drinks;
        }
        public static IEnumerable<IOrderItem> DrinksList { get { return Drinks(); } }

        /// <summary>
        /// Full menu list.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<object> menu = new List<object>()
            {
                new AngryChicken(),
                new CowpokeChili(),
                new DakotaDoubleBurger(),
                new PecosPulledPork(),
                new RustlersRibs(),
                new TexasTripleBurger(),
                new TrailBurger(),

                new BakedBeans(),
                new ChiliCheeseFries(),
                new CornDodgers(),
                new PanDeCampo(),

                new JerkedSoda(),
                new TexasTea(),
                new Water()
            };

            return menu as IEnumerable<IOrderItem>;
        }

        /// <summary>
        /// Searches our Menu for corresponding searchTerms.
        /// </summary>
        /// <param name="orderItem">Type of item they're searching for</param>
        /// <param name="searchTerm">What they're searching for (user input)</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> orderItem, string searchTerm)
        {

        }
    }
}
