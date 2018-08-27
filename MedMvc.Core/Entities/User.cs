
using System.ComponentModel.DataAnnotations;

namespace MedMvc.Core.Entities
{
    public class User : Entity
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool Active { get; set; }
        public bool Locked { get; set; }
    }
}
