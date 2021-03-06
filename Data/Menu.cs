﻿using System;
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
        
        /// <summary>
        /// List of Sides.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                BakedBeans beans = new BakedBeans();
                beans.Size = size;
                sides.Add(beans);
            }

            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                ChiliCheeseFries fries = new ChiliCheeseFries();
                fries.Size = size;
                sides.Add(fries);
            }
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                CornDodgers corn = new CornDodgers();
                corn.Size = size;
                sides.Add(corn);
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                PanDeCampo pan = new PanDeCampo();
                pan.Size = size;
                sides.Add(pan);
            }
            return sides;
        }

        /// <summary>
        /// List of drinks
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            var temp = Enum.GetValues(typeof(Size));
            List<IOrderItem> drinks = new List<IOrderItem>();

            foreach (Size size in temp)
            {
                CowboyCoffee coffee = new CowboyCoffee();
                coffee.Size = size;
                drinks.Add(coffee);
            }

            foreach (Size size in temp)
            {
                JerkedSoda soda = new JerkedSoda();
                soda.Size = size;
                drinks.Add(soda);
            }
            foreach (Size size in temp)
            {
                TexasTea tea = new TexasTea();
                tea.Size = size;
                drinks.Add(tea);
            }

            foreach (Size size in temp)
            {
                Water water = new Water();
                water.Size = size;
                drinks.Add(water);
            }
            return drinks;
        }

        /// <summary>
        /// Full menu list.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();

            foreach(var item in Entrees())
            {
                menu.Add(item);
            }

            foreach(var item in Drinks())
            {
                menu.Add(item);
            }

            foreach (var item in Sides())
            {
                menu.Add(item);
            }
            return menu;
        }

        public static IEnumerable<IOrderItem> All => CompleteMenu();

         

        /// <summary>
        /// Searches our Menu for corresponding search terms.
        /// </summary>
        /// <param name="orderItem">Type of item they're searching for</param>
        /// <param name="searchTerm">What they're searching for (user input)</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(string term)
        {
            if (term == null) return All;

            List<IOrderItem> results = new List<IOrderItem>();

            foreach (var item in CompleteMenu())
            {
                if (item.ToString() != null && item.ToString().Contains(term, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filtering search results by selected category.
        /// </summary>
        /// <param name="order">All of the items on the menu</param>
        /// <param name="filter">Entree, Drinks, or Sides</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> order, IEnumerable<string> filter)
        {
            List<IOrderItem> items = new List<IOrderItem>();

            if (filter == null || filter.Count() == 0) return order;
            foreach(var item in filter)
            {
                if (item.ToString().Equals("Entrees"))
                {
                    foreach(IOrderItem it in order)
                    {
                        if (it is Entree entree) items.Add(entree);
                    }
                }
                if (item.ToString().Equals("Sides"))
                {
                    foreach(IOrderItem it in order)
                    {
                        if (it is Side side) items.Add(side);
                    }
                }
                if (item.ToString().Equals("Drinks"))
                {
                    foreach(IOrderItem it in order)
                    {
                        if (it is Drink drinks) items.Add(drinks);
                    }
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
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menuItems, int? min, int? max)
        {
            if (min == null && max == null) return menuItems;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in menuItems)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in menuItems)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in menuItems)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filtering results by calories.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menuItems, double? min, double? max)
        {
            if (min == null && max == null) return menuItems;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in menuItems)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in menuItems)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in menuItems)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

    }
}
