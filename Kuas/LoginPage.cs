using System;
using System.Windows.Forms;

namespace Kuas
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                emailError.Text = "Email is Empty!";
            }
            else 
            {
                emailError.Text = "";
                if (Controller.IsValidEmail(emailTextBox.Text) == false)
                {
                    emailError.Text = "The Email is not Valid!";
                }
                else
                {
                    if (passwordInput.Text != "")
                    {
                        String email = emailTextBox.Text;
                        String password = passwordInput.Text;
                        if (Controller.isThereAccout(email, password) == true)
                        {
                            new LandingPage().ShowDialog();
                            this.Close();
                            Properties.Settings.Default.isLoggedBefore = true;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
            }
            if (passwordInput.Text == "")
            {
                passwordError.Text = "Password is Empty!";
            }
            else passwordError.Text = "";
           
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if(emailTextBox.Text != "")
            {
                emailError.Text = "";
            }
            if (passwordInput.Text != "")
            {
                passwordError.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); ;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Signup().ShowDialog();
        }

   
    }
}
