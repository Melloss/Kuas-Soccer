using System;
using System.Windows.Forms;

namespace Kuas
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            maleRadioButton.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            if(firstNameInput.Text == "")
            {
                firstNameError.Text = "First Name is Empty!";
            }
            else
            {
                if (lastNameInput.Text == "")
                {
                    lastNameError.Text = "Last Name is Empty!";
                }
                else
                {
                    if (emailTextInput.Text == "")
                    {
                        emailInputError.Text = "Email is Empty!";
                    }
                    else
                    {
                        emailInputError.Text = "";
                        if (Controller.IsValidEmail((emailTextInput.Text)) == false)
                        {
                            emailInputError.Text = "Email is Invalid!";
                        }
                        else
                        {
                            if (passwordInput.Text == "")
                            {
                                passwordInputError.Text = "Password is Empty!";
                            }
                            else
                            {
                                String fName = firstNameInput.Text;
                                String lName = lastNameInput.Text;
                                String em = emailTextInput.Text;
                                String ps = passwordInput.Text;
                                String gender = "";
                                if (maleRadioButton.Checked == true)
                                {
                                    gender = maleRadioButton.Text;
                                }
                                else if (femaleRadioButton.Checked == true)
                                {
                                    gender = femaleRadioButton.Text;
                                }
                                UserAccount account = new UserAccount(fName, lName, em, ps, gender);
                                if(Controller.createAccount(account) == true)
                                {
                                    MessageBox.Show("Account Created Successfully!  ", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();   
                                }
                            }
                        }
                   
                        
                           
                    }
                        
                 
                }
            }
        }

        private void firstNameInput_TextChanged(object sender, EventArgs e)
        {
            if(firstNameInput.Text != "")
            {
                firstNameError.Text = "";
            }
            if (lastNameInput.Text != "")
            {
                lastNameError.Text = "";
            }
            if (emailTextInput.Text != "")
            {
                emailInputError.Text = "";
            }
            if (passwordInput.Text != "")
            {
                passwordInputError.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
