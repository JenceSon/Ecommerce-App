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
    }
}
