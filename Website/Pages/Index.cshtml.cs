using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
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
        public string[] Options { get; set; } 
        // all the options they've selected are stored here (checkboxes)

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            MenuItems = Menu.All;
            SearchTerms = Request.Query["SearchTerms"]; // run Query on user input
            Options = Request.Query["Options"];
            MenuItems = Menu.Search(SearchTerms);
            MenuItems = Menu.FilterByCategory(MenuItems, Options);
        }
    }
}
