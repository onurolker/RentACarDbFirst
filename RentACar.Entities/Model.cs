using System.Collections.Generic;

namespace RentACar.Entities
{
    public partial class Model
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Model()
        {
            this.Cars = new HashSet<Car>();
        }

        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public int TradeId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Car> Cars { get; set; }
        public virtual Trade Trade { get; set; }
    }
}
