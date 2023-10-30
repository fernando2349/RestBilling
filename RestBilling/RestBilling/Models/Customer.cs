namespace RestBilling.Models
{
    public class Customer
    {
        public int id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string Country { get; set; } 

        public string Phone { get; set; } 


        public ICollection<Order>? Orders { get; set; }




    }
}
