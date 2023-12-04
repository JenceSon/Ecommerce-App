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
            SellerMainPage form = new SellerMainPage();
            form.Show();
            this.Hide();
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