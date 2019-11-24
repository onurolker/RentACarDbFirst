using MaterialSkin.Controls;
using System.Windows.Forms;
using RentACar.BLL;
namespace RentACarWinUI.Forms
{
    public partial class SignUpForm : MaterialForm
    {
        public SignUpForm()
        {
           
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, System.EventArgs e)
        {
            int sonuc = 0;
            char[] resultString = txtSignUpMailAdress.Text.ToCharArray();
            for (int i = 0; i < txtSignUpMailAdress.Text.Length; i++)
            {
                if (resultString[i].ToString() == "@")
                {
                    sonuc++;
                }
            }
            if (sonuc != 1 || txtSignUpMailAdress.Text.Replace(" ", "") == "@")
            {
                MessageBox.Show("Lütfen Mail adresi giriniz..");
                return;
            }
    


            RentACar.Entities.User user = new RentACar.Entities.User
            {
               
                MailAdress = txtSignUpMailAdress.Text.ToLower(),
                Password = txtSignUpPW.Text,
            };
            UserController userController = new UserController();
            string result = userController.AddUser(user);
            MessageBox.Show(result);
        }
    }
}
