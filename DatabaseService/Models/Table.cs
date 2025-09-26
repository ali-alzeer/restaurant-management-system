using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseService.Models
{
  public class Table
  {
    [Column(TypeName = "varchar(36)")]
    public string Id { get; set; } = Guid.NewGuid().ToString().ToUpper();

    [Required]
    [MaxLength(4)]
    public required string Number { get; set; }
  }
}