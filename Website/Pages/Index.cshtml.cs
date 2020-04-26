using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// Search input from the user.
        /// </summary>
        public string SearchTerms { get; set; }

        public string EntreeSearch { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            SearchTerms = Request.Query["SearchTerms"]; // run Query on property?
            EntreeSearch = Request.Query["EntreeSearch"]; 
        }
    }
}
