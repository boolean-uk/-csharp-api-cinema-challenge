using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Models;

namespace api_cinema_challenge
{
    [Table("customers")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
        public Customer() { }

        public Customer(int id)
        {
            Id = id;
        }

        public Customer(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetUpdatedAt()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
