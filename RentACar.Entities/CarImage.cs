namespace RentACar.Entities
{
    public partial class CarImage
    {
        public int ID { get; set; }
        public byte[] Image { get; set; }
        public int CarID { get; set; }

        public virtual Car Cars { get; set; }
    }
}
