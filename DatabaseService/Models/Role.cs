using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseService.Models
{
  public class Role
  {
    [Column(TypeName = "varchar(36)")]
    public string Id { get; set; } = Guid.NewGuid().ToString().ToUpper();

    [Required]
    [MaxLength(50)]
    public required string Name { get; set; }

    public ICollection<User> Users { get; set; } = [];
  }
}