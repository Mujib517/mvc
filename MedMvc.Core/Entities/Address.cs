using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedMvc.Core.Entities
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string HouseNo { get; set; }
        public string ApartmentName { get; set; }
        public string Landmark { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
    }
}