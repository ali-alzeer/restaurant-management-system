using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseService.Models
{
  public class Ingredient
  {
    public string Id { get; set; } = Guid.NewGuid().ToString();
    [Required]
    [MaxLength(250)]
    public required string Name { get; set; }
    [Required]
    public required double Price { get; set; }
    [Required]
    public required double Quantity { get; set; }

  }
}