using CustomerSearch.App.Models;
using CustomerSearch.App.Services;
using CustomerSearch.Core.Services;
using System.Web.Mvc;

namespace CustomerSearch.App.Controllers
{
    [RoutePrefix("")]
    public class DefaultController : Controller
    {
        readonly ICustomerDatabase _database;

        public DefaultController() : this(null)
        {
        }

        public DefaultController(ICustomerDatabase database = null)
        {
            _database = database ?? new CustomerDatabase();
        }

        [Route("")]
        public ActionResult Index(string searchPhrase)
        {
            var searchBar = new SearchBarService(_database);

            var model = new SearchViewModel
            {
                SearchPhrase = searchPhrase,
                Customers = searchBar.SearchByName(searchPhrase)
            };

            return View(model);
        }
    }
}