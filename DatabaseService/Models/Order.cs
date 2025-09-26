using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseService.Models
{
  public class Order
  {
    [Column(TypeName = "varchar(36)")]
    public string Id { get; set; } = Guid.NewGuid().ToString().ToUpper();

    [Required]
    public required string TableId { get; set; }
    [Required]
    public required Table Table { get; set; }

    [Required]
    public required DateTime OrderDate { get; set; } = DateTime.Now;
    [Required]
    public required DateTime DeliveryDate { get; set; } = DateTime.Now;

    public ICollection<MenuItem> MenuItems { get; set; } = [];
  }
}