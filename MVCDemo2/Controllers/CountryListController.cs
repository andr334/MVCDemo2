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
            var lista = GetCountryListsViaEntity();

            return View(lista);
        }

        private static DbSet<CountryList> GetCountryListsViaEntity()
        {
            var countryListContext = new CountryListContext();
            var lista = countryListContext.CountryList;
            return lista;
        }

        public ActionResult Data()
        {
            var list = GetCountryListsViaEntity();

            return Json(list, JsonRequestBehavior.AllowGet);
        }

      
    }
}