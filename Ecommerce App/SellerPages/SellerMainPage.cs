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
