using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseService.Models
{
  public class User
  {
    [Column(TypeName = "varchar(36)")]
    public string Id { get; set; } = Guid.NewGuid().ToString().ToUpper();

    [Required]
    [MaxLength(50)]
    public required string UserName { get; set; }

    [Required]
    [EmailAddress]
    [MaxLength(50)]
    public required string Email { get; set; }

    [Required]
    [MinLength(6)]
    [MaxLength(50)]
    public required string Password { get; set; }

    [Required]
    [MaxLength(50)]
    public required string FirstName { get; set; }

    [Required]
    [MaxLength(50)]
    public required string LastName { get; set; }

    [Required]
    public required DateTime CreatedAt { get; set; }

    [DefaultValue(true)]
    public bool IsActive { get; set; } = true;

    [MaxLength(250)]
    public string? ImageUrl { get; set; }

    public ICollection<Role> Roles { get; set; } = [];
  }
}