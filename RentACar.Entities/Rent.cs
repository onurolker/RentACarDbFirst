using System;

namespace RentACar.Entities
{
    public partial class Rent
    {
        public int RentID { get; set; }
        public int UserID { get; set; }
        public int CarID { get; set; }
        public Nullable<int> RentPeriod { get; set; }
        public decimal TotalPrice { get; set; }

        public virtual Car Cars { get; set; }
        public virtual User Users { get; set; }
    }
}
