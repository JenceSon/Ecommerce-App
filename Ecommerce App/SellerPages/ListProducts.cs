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
    public partial class ListProducts : UserControl
    {
        public ListProducts()
        {
            InitializeComponent();
        }

        private void SeeMoreBtn_Click(object sender, EventArgs e)
        {
            Product_Information form = new Product_Information();
            form.Show();
        }

        public void CreateProducts()
        {
            SqlConnection conn = new SqlConnection(ConnectDB.connString);
            SqlCommand cmd = new SqlCommand(@"Select * from [Product] where shop_id = @sid", conn);
            cmd.Parameters.AddWithValue("@sid", SellerMainPage.shop.Shop_id);

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                SellerMainPage.Products.Add(new Product(
                    dr["product_id"].ToString(),
                    dr["name"].ToString(),
                    dr["description"].ToString(),
                    Convert.ToInt32(dr["total_remaining"]),
                    Convert.ToInt32(dr["no_sales"]),
                    Convert.ToDouble(dr["minimum_price"]),
                    Convert.ToDouble(dr["maximum_price"]),
                    dr["img"].ToString(),
                    dr["category_id"].ToString()
                    ));
            }
        }
        public void LoadProducts()
        {
            IEnumerator<Product> it = SellerMainPage.Products.GetEnumerator();
            while (it.MoveNext())
            {
                Product product = it.Current;
                ProductTable.Rows.Add(product.Product_id, product.Name, product.TotalRemaining, product.MinPrice, product.MaxPrice);
            }
        }
    }
}
