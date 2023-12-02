using Ecommerce_App.Authentication;
using Guna.UI2.WinForms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ecommerce_App
{
    public partial class Login : Form
    {
        static SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=BTL;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
            //conn.Open();
            string userEmail = guna2TextBox1.Text;
            string userPassword = guna2TextBox3.Text;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register login = new Register();
            login.Show();
            this.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string userEmail = guna2TextBox1.Text;
            string userPassword = guna2TextBox3.Text;

            bool isValidLogin = checkLogin(userEmail, userPassword);

            if (isValidLogin)
            {
                mainPage mainpage = new mainPage();
                mainpage.Show();
                this.Hide();
                // Login successful
                // Add your logic here
            }
            else
            {
                // Login failed
                // Add your logic here
            }
        }

        //demo login 
        //TODO: delete if needed
        private bool checkLogin(string email, string password)
        {
            bool res = false;

            string query = "SELECT COUNT(*) FROM [User] WHERE linking_email = @Email AND password = @Password";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                conn.Open();
                int count = (int)command.ExecuteScalar();
                conn.Close();

                res = count > 0;
            }

            return res;
        }

        private void guna2HtmlLabel6_Click_1(object sender, EventArgs e)
        {

        }
    }
}