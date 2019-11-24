using System;
using System.Collections.Generic;

namespace RentACar.Entities
{
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            this.Images = new HashSet<CarImage>();
            this.Rent = new HashSet<Rent>();
        }

        public int CarID { get; set; }
        public int ModelId { get; set; }
        public decimal KM { get; set; }
        public System.DateTime SalesDate { get; set; }
        public Nullable<int> ChasisNo { get; set; }
        public Nullable<decimal> DayOfPrice { get; set; }
        public string Description { get; set; }

        public virtual Model Model { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarImage> Images { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rent { get; set; }
    }
}
