using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using MVCDemo2.Models;

namespace MVCDemo2.Controllers
{
    public class CountryListController : Controller
    {
        // GET: Employee
        public ActionResult Details(int id)
        {
            var countryListContext = new CountryListContext();
            var countryList = countryListContext.CountryList.Single(ctr => ctr.CountryID == id);

            return View(countryList);
        }

        public ActionResult List()
        {
            var countryListContext = new CountryListContext();
            var list = countryListContext.CountryList;

            return View(list);
        }
    }
}