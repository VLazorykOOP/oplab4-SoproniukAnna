using System;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (username == "a" && password == "a")
            {
                MessageBox.Show("Успішний вхід!");
                MainForm mainForm = new MainForm();
                mainForm.Show(); 
                this.Hide(); 
            }
            else
                MessageBox.Show("Невірний логін або пароль. Спробуйте ще раз.");

        }
    }
}
