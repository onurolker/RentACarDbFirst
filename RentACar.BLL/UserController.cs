using RentACar.Entities;
using RentACar.DAL;
namespace RentACar.BLL
{
   public  class UserController
    {
        UserManagement usersManagement;
        public UserController()
        {
            usersManagement = new UserManagement();
        }
        public string AddUser(User user)
        {
            string message = "Kayıt Başarılı..";
            if (string.IsNullOrWhiteSpace(user.MailAdress) || string.IsNullOrWhiteSpace(user.Password))
            {
                message = "Mail veya Şifre Boş bırakılamaz...";
                return message;
            }
            var result = usersManagement.AddUsers(user);
            if (result != null)
            {
                message = "Böyle bir kayıt zaten var...";
            }
            return message;
        }
    }
}
