using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }

        [Column(TypeName = "int")]
        public int ProductId { get; set; }

        [Column(TypeName = "int")]
        public int UserId { get; set; }
        [Column(TypeName = "int")]
        public int Amount { get; set; }

        public virtual ICollection<Product>?Products { get; set; }

        public virtual ICollection<User>?Users { get; set; }

    }
}
