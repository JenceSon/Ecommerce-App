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
    public partial class ShopInformation : UserControl
    {
        public ShopInformation()
        {
            InitializeComponent();
        }
        public void LoadShopInfo()
        {
            ShopID.Text = SellerMainPage.shop.Shop_id.ToString();
            ShopName.Text = SellerMainPage.shop.Name.ToString();
            DateJoin.Text = SellerMainPage.shop.DateJoined.ToString();
            NoProducts.Text = SellerMainPage.shop.No_product.ToString();
            NoFollowers.Text = SellerMainPage.shop.No_folower.ToString();
            NoFollowing.Text = SellerMainPage.shop.No_following.ToString();
            Rating.Text = SellerMainPage.shop.Rating.ToString();
            Url.Text = SellerMainPage.shop.UrlLink.ToString();
            BioTxtBox.Text = SellerMainPage.shop.Bio.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectDB.connString);
            SqlCommand cmd;

            if (BioTxtBox.Text.Length > 0)
            {
                SellerMainPage.shop.Bio = BioTxtBox.Text;
                cmd = new SqlCommand(@"update Shop set [bio] = @bio where shop_id = @sid", conn);
                cmd.Parameters.AddWithValue("@bio",SellerMainPage.shop.Bio);
            }
            else
            {
                SellerMainPage.shop.Bio = "No description";
                BioTxtBox.Text = SellerMainPage.shop.Bio;
                cmd = new SqlCommand(@"update Shop set [bio] = default where shop_id = @sid", conn);
            }
            cmd.Parameters.AddWithValue("@sid",SellerMainPage.shop.Shop_id);

            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Successfully change", "Notification",MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            BioTxtBox.Text = SellerMainPage.shop.Bio.ToString();
        }
    }
}
