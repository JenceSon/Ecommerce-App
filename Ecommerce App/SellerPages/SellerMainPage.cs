using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce_App.SellerPages
{
    public partial class SellerMainPage : Form
    {
        public SellerMainPage()
        {
            InitializeComponent();
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
            ListProducts.Visible = true;
            ShopInformation.Visible = false;
            Finance.Visible = false;
            ListProducts.BringToFront();
        }

        private void OverviewButton_Click(object sender, EventArgs e)
        {
            ShopInformation.Visible = true;
            ListProducts.Visible = false;
            Finance.Visible = false;
            ShopInformation.BringToFront();
        }

        private void FinanceButton_Click(object sender, EventArgs e)
        {
            Finance.Visible = true;
            ShopInformation.Visible = false;
            ListProducts.Visible = false;
        }
    }
}
