using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDemo2.Models
{
    public class CountryListContext : DbContext
    {
        public DbSet<CountryList> CountryList { get; set; }
    }
}