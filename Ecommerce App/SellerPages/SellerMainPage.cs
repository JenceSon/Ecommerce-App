using Ecommerce_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce_App.SellerPages
{
    public partial class SellerMainPage : Form
    {
        public static Shop shop;
        public SellerMainPage(string shop_id)
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection(ConnectDB.connString);
            SqlCommand cmd = new SqlCommand(@"select * from Shop where shop_id = @shop_id",conn);

            cmd.Parameters.AddWithValue("@shop_id",shop_id);

            conn.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            

            conn.Close();

            foreach(DataRow dr in dt.Rows)
            {
                shop = new Shop(
                    Convert.ToString(dr["shop_id"]),
                    Convert.ToString(dr["bio"]),
                    Convert.ToString(dr["url_link"]),
                    Convert.ToString(dr["name"]),
                    (Convert.ToDateTime(dr["date_joined"]).Date).ToString("yyyy/MM/dd"),
                    Convert.ToInt32(dr["no_following"]),
                    Convert.ToInt32(dr["no_follower"]),
                    Convert.ToInt32(dr["no_product"]),
                    Convert.ToDouble(dr["rating"])
                    );
            }    
            this.Text = "Hello " + shop.Shop_id;
            this.shopInformation.Load_shop_info();
        }

        private void LogoButton_MouseEnter(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginSeller form = new LoginSeller();
            form.Show();
            this.Hide();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            listProducts.Visible = true;
            finance.Visible = false;
            shopInformation.Visible = false;
            listProducts.BringToFront();
        }

        private void FinanceButton_Click(object sender, EventArgs e)
        {
            listProducts.Visible = false;
            finance.Visible = true;
            shopInformation.Visible = false;
            finance.BringToFront();
        }

        private void OverviewButton_Click(object sender, EventArgs e)
        {
            listProducts.Visible = false;
            finance.Visible = false;
            shopInformation.Visible = true;
            shopInformation.BringToFront();
        }
    }
}
