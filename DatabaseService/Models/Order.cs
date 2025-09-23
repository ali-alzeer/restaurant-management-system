using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseService.Models
{
  public class Order
  {
    public string Id { get; set; } = Guid.NewGuid().ToString();

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