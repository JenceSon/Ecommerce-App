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
        public static List<Product> Products;
        public SellerMainPage(string shop_id)
        {
            InitializeComponent();
           
            #region create shop
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
            this.Text = "Hello " + shop.Name;
            this.shopInformation.LoadShopInfo();
            #endregion


            #region load products of shop
            Products = new List<Product>();
            this.listProducts.CreateProducts();
            this.listProducts.LoadProducts();
            #endregion


            #region load finance
            this.finance.LoadFinance();
            #endregion

        }
        #region event
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
        #endregion

        #region method
        public void RefreshShopInfo()
        {
            SqlConnection conn = new SqlConnection(ConnectDB.connString);
            SqlCommand cmd = new SqlCommand(@"select * from Shop where shop_id = @shop_id", conn);

            cmd.Parameters.AddWithValue("@shop_id", shop.Shop_id);

            conn.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);


            conn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                shop.Shop_id = Convert.ToString(dr["shop_id"]);
                shop.Bio = Convert.ToString(dr["bio"]);
                shop.UrlLink = Convert.ToString(dr["url_link"]);
                shop.Name = Convert.ToString(dr["name"]);
                shop.DateJoined = (Convert.ToDateTime(dr["date_joined"]).Date).ToString("yyyy/MM/dd");
                shop.No_following = Convert.ToInt32(dr["no_following"]);
                shop.No_folower = Convert.ToInt32(dr["no_follower"]);
                shop.No_product = Convert.ToInt32(dr["no_product"]);
                shop.Rating = Convert.ToDouble(dr["rating"]);
            }
            this.Text = "Hello " + shop.Name;
            this.shopInformation.LoadShopInfo();

        }
        #endregion
    }
}
