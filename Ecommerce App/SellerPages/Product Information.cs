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
    public partial class Product_Information : Form
    {
        public Product_Information()
        {
            InitializeComponent();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProduct form = new AddProduct();
            form.Show();
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            ModifyProduct form = new ModifyProduct();
            form.Show();
        }

        private void SeeVariantBtn_Click(object sender, EventArgs e)
        {
            Variant form = new Variant();
            form.Show();
        }
    }
}
