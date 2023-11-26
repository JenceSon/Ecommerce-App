using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce_App.Page
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            Authentication.mainPage newWindow = new Authentication.mainPage();
            newWindow.Show();
            this.Close();
        }
    }
}
