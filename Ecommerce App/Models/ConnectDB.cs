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
        static string connString = "Data Source=MSI;Initial Catalog=BTL_db_official;Integrated Security=True";
        static SqlConnection conn = new SqlConnection(connString);
    }
}
