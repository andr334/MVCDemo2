using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo2.Models
{
    [Table("CountryList")]
    public class CountryList
    {
        [Key]
        public int CountryID { get; set; }
        public string Code { get; set; }
        public string English { get; set; }
        public string Hebrew { get; set; }
    }
}