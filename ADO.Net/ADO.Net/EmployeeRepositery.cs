using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PayrollADO.NET
{
    public class EmployeeRepositery
    {
        //For sql authentication
        public static string connectionString = @"Data Source=SHUBHAM@SVG MINGW64;Initial Catalog=payroll_services;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
    }
}