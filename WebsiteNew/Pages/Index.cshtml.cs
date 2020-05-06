using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace WebsiteNew.Pages
{
    /// <summary>
    /// This is Page Model
    /// </summary>
    public class IndexModel : PageModel
    {
        [BindProperty]
        /// <summary>
        /// Search input from the user.
        /// </summary>
        public string SearchTerms { get; set; }

        [BindProperty]
        public IEnumerable<IOrderItem> MenuItems { get; protected set; }

        [BindProperty]
        public IEnumerable<SodaFlavor> SodaFlavors { get; set; }

        [BindProperty]
        public string[] Options { get; set; }
        // all the options they've selected are stored here (checkboxes)

        public int? minCalories { get; set; }

        public int? maxCalories { get; set; }

        public double? minPrice { get; set; }

        public double? maxPrice { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        } 
        public void OnGet(int? minCalories, int? maxCalories, double? minPrice, double? maxPrice)
        {
            this.minCalories = minCalories;
            this.maxCalories = maxCalories;
            this.minPrice = minPrice;
            this.maxPrice = maxPrice;

            MenuItems = Menu.All;
            SearchTerms = Request.Query["SearchTerms"]; // run Query on user input
            Options = Request.Query["Options"];
            
            // Calories:
            /*
            if(SearchTerms != null)
            {
                MenuItems = MenuItems.Where(item =>
                item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }
            */

            
            MenuItems = Menu.Search(SearchTerms);
            MenuItems = Menu.FilterByCategory(MenuItems, Options);
            MenuItems = Menu.FilterByCalories(MenuItems, minCalories, maxCalories);
            MenuItems = Menu.FilterByPrice(MenuItems, minPrice, maxPrice);
            
        }
    }
}
