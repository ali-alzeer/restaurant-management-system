using System.ComponentModel.DataAnnotations;

namespace DatabaseService.Models
{
  public class Role
  {

    public string Id { get; set; } = Guid.NewGuid().ToString();

    [Required]
    [MaxLength(50)]
    public required string Name { get; set; }

    public ICollection<User> Users { get; set; } = [];
  }
}