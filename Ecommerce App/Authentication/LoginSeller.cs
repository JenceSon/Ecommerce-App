using Ecommerce_App.Models;
using Ecommerce_App.SellerPages;
using Guna.UI2.WinForms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ecommerce_App
{
    public partial class LoginSeller : Form
    {
        public LoginSeller()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //query
            SqlConnection conn = new SqlConnection(ConnectDB.connString);
            string query = @"select dbo.check_login_seller(@user_name,@email,@pwd)";
            SqlCommand cmd = new SqlCommand(query, conn);

            //para
            SqlParameter user_name = new SqlParameter();
            user_name.ParameterName = "@user_name";
            user_name.SqlDbType = SqlDbType.VarChar;
            
            SqlParameter email = new SqlParameter();
            email.ParameterName = "@email";
            email.SqlDbType = SqlDbType.VarChar;
            
            SqlParameter password = new SqlParameter();
            password.ParameterName = "@pwd";
            password.SqlDbType = SqlDbType.VarChar;

            //pass para
            if (EmailTextBox.Text.Contains('@'))
            {
                email.Value = EmailTextBox.Text;
                user_name.Value = DBNull.Value;
            }
            else
            {
                user_name.Value= EmailTextBox.Text;
                email.Value = DBNull.Value;
            }    
            password.Value = PasswordTextBox.Text;

            cmd.Parameters.Add(user_name);
            cmd.Parameters.Add(email);
            cmd.Parameters.Add(password);

            //open and exec
            conn.Open();
            string shop_id = (string)cmd.ExecuteScalar();

            if (shop_id == "Deny")
            {
                MessageBox.Show("Wrong information !!","Deny login",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                SellerMainPage form = new SellerMainPage(shop_id);
                form.Show();
                this.Hide();

            }
            conn.Close();
        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == "")
            {
                EmailTextBox.Text = "Enter your email or username";
                EmailTextBox.ForeColor = Color.LightGray;
            }
        }

        private void PwdTextBox_Leave(Object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.PasswordChar = '\0';
                PasswordTextBox.Text = "Enter your password";
                PasswordTextBox.ForeColor = Color.LightGray;

            }

        }
        private void EmailTextBox_Enter(Object sender, EventArgs e)
        {
            if (EmailTextBox.Text == "Enter your email or username")
            {
                EmailTextBox.Text = "";
                EmailTextBox.ForeColor = Color.Black;
            }
        }

        private void PwdTextBox_Enter(Object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "Enter your password")
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.ForeColor = Color.Black;
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}