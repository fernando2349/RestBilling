using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestBilling.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public Guid OrderNumber { get; set; } = Guid.NewGuid(); // Establece un nuevo GUID por defecto

        [Required] 
        public int CustomerId { get; set; }

        public decimal TotalAnount { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }  
    }
}
