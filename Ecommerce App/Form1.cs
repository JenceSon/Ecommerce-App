using System.Data;
using System.Data.SqlClient;

namespace Ecommerce_App
{
    public partial class Form1 : Form
    {
        static SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=BTL;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            //conn.Open();
            showdata();

        }
        public void showdata()
        {
            SqlDataAdapter adpt = new SqlDataAdapter("select * from [User]", conn);
            DataTable dt  = new DataTable();
            adpt.Fill(dt);
            test.DataSource = dt;
        }
    }
}