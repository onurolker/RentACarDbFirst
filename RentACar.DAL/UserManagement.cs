using RentACar.Entities;
using System;
using System.Linq;
namespace RentACar.DAL
{
   public class UserManagement
    {
        RentACarEntities entities;
        public UserManagement()
        {
            entities = new RentACarEntities();
        }

        public User AddUsers(User user)
        {
            //  int userId = users.UserID;
            //  string firstName = users.FirstName;
            //  string lastName = users.LastName;
            //  string phoneNumber = users.PhoneNumber;
            //  string tcNo = users.TCNo;
            //  var birthDate = users.BirthDate;
            //  string province = users.ProvinceOfResidence;
            //  byte[] copyOfIdentity = users.CopyOfIdentityCard;

            //var result=entities.SP_USERSINSERT(userId, firstName, lastName, phoneNumber, tcNo, birthDate, province, copyOfIdentity);

            //  bool isAdded = result > 0;   
            //  return isAdded;
            var result = entities.Set<User>().Add(user);

            return result;

        }
        //public User Register(User user)
        //{
        //    var result = entities.Set<User>().Add(user);
          
        //    return result;
        //}
    }
}
