using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseService.Models
{
  public class Table
  {
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [Required]
    [MaxLength(4)]
    public required string Number { get; set; }
  }
}