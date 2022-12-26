using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection connect = new SqlConnection(
            @"Data Source=DESKTOP-U0NLI58\MSSQLSERVER01;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
    }
}
