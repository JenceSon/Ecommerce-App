using Ecommerce_App.Authentication;
using Ecommerce_App.SellerPages;
using Guna.UI2.WinForms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ecommerce_App
{
    public partial class LoginSeller : Form
    {
        static SqlConnection conn = new SqlConnection("Data Source=HOANGPHI1003\\SQLEXPRESS;Initial Catalog=BTL;Integrated Security=True");
        public LoginSeller()
        {
            InitializeComponent();
            //conn.Open();
            string userEmail = EmailTextBox.Text;
            string userPassword = PasswordTextBox.Text;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register loginSeller = new Register();
            loginSeller.Show();
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
            string userEmail = EmailTextBox.Text;
            string userPassword = PasswordTextBox.Text;

            bool isValidLogin = checkLogin(userEmail, userPassword);

            if (isValidLogin)
            {
                SellerPages.SellerMainPage mainpage = new SellerMainPage();
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

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}