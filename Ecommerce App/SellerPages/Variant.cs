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
    public partial class Variant : Form
    {
        public Variant()
        {
            InitializeComponent();
        }

        private void AddVariantBtn_Click(object sender, EventArgs e)
        {
            AddVariant form = new AddVariant();
            form.Show();
        }
    }
}
