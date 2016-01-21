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

        private static List<CountryList> GetCountryListViaAdoNet()
        {
            var list = new List<CountryList>();
            using (
                var con = new SqlConnection("Data Source=fx-db-qa,2555;Initial Catalog=FXNET;Integrated Security=True"))
            {
                con.Open();
                var comm = new SqlCommand("SELECT * FROM CountryList", con);
                var reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new CountryList
                    {
                        CountryID = (int) reader["CountryID"],
                        Code = reader["Code"].ToString(),
                        English = (string) reader["English"],
                        Hebrew = (string) reader["Hebrew"]
                    });
                }
            }
            return list;
        }
    }
}