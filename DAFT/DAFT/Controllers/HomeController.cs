using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nutritionix;

namespace DAFT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var nutrisearch = new NutriSearch();
            var search = nutrisearch.Search("Cheddar Cheese");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

namespace DAFT.Controllers
{
    public class NutriSearch
    {
        private const string MyApiId = "35d51d50";
        private const string MyApiKey = "d19943f980aa9d4cd5fd932ac4b99fb7";

        public SearchResult[] Search(string query)
        {
            var nutritionix = new NutritionixClient();
            nutritionix.Initialize(MyApiId, MyApiKey);

            var request = new SearchRequest { Query = query, IncludeAllFields = true};
            SearchResponse response = nutritionix.SearchItems(request);

            return response.Results;
        }

        public Item Retrieve(string id)
        {
            var nutritionix = new NutritionixClient();
            nutritionix.Initialize(MyApiId, MyApiKey);

            return nutritionix.RetrieveItem(id);
        }
    }
}