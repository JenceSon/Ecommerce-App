using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ecommerce_App.Authentication
{
    class DBConnect
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        private string conString = "";

        public string connection()
        {
            //edit conString here
            conString = "Data Source=HOANGPHI1003\\SQLEXPRESS;Initial Catalog=BTL;Integrated Security=True";
            return conString;
        }
    };
}
