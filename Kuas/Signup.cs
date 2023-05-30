using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuas
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            String fName = firstName.Text;
            String lName = lastName.Text;
            int a = Convert.ToInt32(age.Value);
            String em = email.Text;
            String ps = password.Text;
            String gender = "";
            if(maleRadioButton.Checked == true)
            {
                gender = maleRadioButton.Text;
            }
            else if (femaleRadioButton.Checked == true)
            {
                gender = femaleRadioButton.Text;
            }
            UserAccount account = new UserAccount(fName,lName,a,em,ps,gender);
            Controller.createAccount(account);
        }
    }
}
