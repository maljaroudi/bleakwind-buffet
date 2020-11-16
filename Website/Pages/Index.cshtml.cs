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
        /// <summary>
        /// Get Request Initalizer. Functions for searching for categories, item name, price, size and description
        /// </summary>
        /// <param name="PriceMin"> Minimum Price, if entered</param>
        /// <param name="PriceMax">Maximum Price, if entered</param>
        /// <param name="CaloriesMin">Minimum Calories if entered</param>
        /// <param name="CaloriesMax">Max calories if entered</param>
        public void OnGet(double? PriceMin, double? PriceMax, uint? CaloriesMin, uint? CaloriesMax )
        {
            Menus = Menu.All;
            if (SearchTerms != null)
            {
                var terms = SearchTerms.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Menus = Menus.Where(item => terms.Any(x => item.ToString() != null && item.ToString().Contains(x, StringComparison.InvariantCultureIgnoreCase) || item.Description != null && item.Description.Contains(x, StringComparison.InvariantCultureIgnoreCase))).Distinct();
                
                //Old method, searches for one entry.
                //Menus = Menus.Where(item => item.ToString() != null && item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase) || item.Description != null && item.Description.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }

            if (Category != null && Category.Length != 0)
            {
                //Clever, gets base type of the item type and converts it to string. Thus, any matching string from Category & the class will show.
                Menus = Menus.Where(item => item.GetType()!=null &&  Category.Contains(item.GetType().BaseType.Name)) ;
            }

            //Marked as deprecated
            //Menus = Menu.Search(SearchTerms);
            //Menus = Menu.FilterByCategory(Category, Menus);
            Menus = Menu.FilterByPrice(Menus, PriceMin, PriceMax);
            Menus = Menu.FilterByCalories(Menus, CaloriesMin, CaloriesMax);
        }
    }
}
