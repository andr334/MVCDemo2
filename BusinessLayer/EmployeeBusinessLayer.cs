using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        string connectionString = ConfigurationManager.COnectioSTring["DBCS"].ConnectionString;
        List<Employee> employees = new List<Employee>();
        using (SqlConnection con = new SqlCOnnection(connectionString))
    {
        SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
        cmd.CommandType = CommandType.StoredProcedure;

    }
    }
}
