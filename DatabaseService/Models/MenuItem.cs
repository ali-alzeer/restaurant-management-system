using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseService.Models
{
  public class MenuItem
  {
    public string Id { get; set; } = Guid.NewGuid().ToString();
    [Required]
    [MaxLength(250)]
    public required string Name { get; set; }
    [Required]
    public required double Price { get; set; }

    public ICollection<Ingredient> Ingredients { get; set; } = [];
  }
}