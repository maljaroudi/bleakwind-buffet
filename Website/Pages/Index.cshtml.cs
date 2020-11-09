using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    [BindProperties(SupportsGet = true)]
    public class IndexModel : PageModel
    {

        public IEnumerable<IOrderItem> Menus { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Category from query
        /// </summary>
        public string[] Category { get; set; }

        


        /// <summary>
        /// Property for search query
        /// </summary>
        public string SearchTerms { get; set; }

        public void OnGet(double? PriceMin, double? PriceMax, uint? CaloriesMin, uint? CaloriesMax )
        {
            Menus = Menu.Search(SearchTerms);
            Menus = Menu.FilterByCategory(Category, Menus);
            Menus = Menu.FilterByPrice(Menus, PriceMin, PriceMax);
            Menus = Menu.FilterByCalories(Menus, CaloriesMin, CaloriesMax);
        }
    }
}
