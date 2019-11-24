using MaterialSkin;
using MaterialSkin.Controls;
using RentACarWinUI.Forms.Admin;
using RentACarWinUI.Forms.User;

namespace RentACarWinUI.Forms
{
    public partial class RentACarMainForm : MaterialForm
    {
        public RentACarMainForm()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
        }

        private void araçlarıListeleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ListCarForm listCarForm = new ListCarForm();
            listCarForm.MdiParent = this;
            listCarForm.Show();
        }

        private void btnSignUp_Click(object sender, System.EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.MdiParent = this;
            signUpForm.Show();
        }

        private void btnSignIn_Click(object sender, System.EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.MdiParent = this;
            signInForm.Show();
        }

        private void RentACarMainForm_Load(object sender, System.EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void profilimiGörüntüleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MyProfilViewForm myProfilView = new MyProfilViewForm();
            myProfilView.MdiParent = this;
            myProfilView.Show();
        }

        private void profiliDüzenleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            RentACarUsersLoginForm rentACarUsersLogIn = new RentACarUsersLoginForm();
            rentACarUsersLogIn.ShowDialog();
        }

        private void üyeleriGörüntüleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ListUsersForm listUsersForm = new ListUsersForm();
            listUsersForm.MdiParent = this;
            listUsersForm.Show();
        }

        private void arabaEkleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();
            addCarForm.MdiParent = this;
            addCarForm.Show();
        }

        private void kiralananlarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            RentedCarForm rentedCar = new RentedCarForm();
            rentedCar.MdiParent = this;
            rentedCar.Show();
        }
    }
}
