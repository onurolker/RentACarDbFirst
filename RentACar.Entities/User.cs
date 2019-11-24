using System;
using System.Collections.Generic;

namespace RentACar.Entities
{
    public class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Rent = new HashSet<Rent>();
        }

        public int UserID { get; set; }
        public string MailAdress { get; set; }
        public string Password { get; set; }
        public bool UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string TCNo { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string ProvinceOfResidence { get; set; }
        public byte[] CopyOfIdentityCard { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rent { get; set; }
    }
}
