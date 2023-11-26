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
using static System.Net.Mime.MediaTypeNames;

namespace Ecommerce_App.Authentication
{
    public partial class mainPage : Form
    {
        static SqlConnection conn = new SqlConnection("Data Source=HOANGPHI1003\\SQLEXPRESS;Initial Catalog=BTL;Integrated Security=True");
        public mainPage()
        {
            InitializeComponent();
            showCategory();
        }

        private void mainPage_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void showCategory()
        {
            SqlDataAdapter adpt = new SqlDataAdapter("select category_name from Category;", conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlDataAdapter adpt = new SqlDataAdapter("select name, maximum_price from Product_name;", conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Page.Account newWindow = new Page.Account();
            newWindow.Show();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Page.Cart newpage = new Page.Cart();
            newpage.Show();
            this.Close();
        }
    }
}
