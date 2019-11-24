using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarWinUI.Forms
{
    public partial class SignInForm : MaterialForm
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void lblSignInForgetPW_Click(object sender, EventArgs e)
        {
            ForgetMyPasswordForm forgetMyPWForm = new ForgetMyPasswordForm();
            forgetMyPWForm.Show();
        }
    }
}
