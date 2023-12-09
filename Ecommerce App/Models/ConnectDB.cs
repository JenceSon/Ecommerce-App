using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_App.Models
{
    internal class ConnectDB
    {
        public static string connString = "Data Source=MSI;Initial Catalog=BTL_db_official_demo;Integrated Security=True";
        //public static SqlConnection conn = new SqlConnection(connString);
    }
}
