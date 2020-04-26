using System;
using System.Collections.Generic;
using System.Linq;
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
        /// Searches our Menu for corresponding search terms.
        /// </summary>
        /// <param name="orderItem">Type of item they're searching for</param>
        /// <param name="searchTerm">What they're searching for (user input)</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(string term)
        {
            if (term == null) return EntreeList;
            List<IOrderItem> results = new List<IOrderItem>();

            foreach (var item in CompleteMenu())
            {
                if (item != null && item.ToString().Contains(term))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filtering search results by selected category.
        /// </summary>
        /// <param name="order"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> order, IEnumerable<string> filter)
        {
            if (filter == null || filter.Count() == 0) return null;

            List<IOrderItem> items = new List<IOrderItem>();

            foreach(var item in order)
            {
                if(order.ToString() != null && order.ToString().Contains(filter.ToString()))
                {
                    items.Add(item);
                }
            }
            return items;
        }

        /// <summary>
        /// Filtering results by calories.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> calories, int? min, int? max)
        {
            if (min == null && max == null) return calories;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (Entree item in calories)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (Entree item in calories)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (Entree item in calories)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
        
    }
}
