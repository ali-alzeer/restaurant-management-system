using System.ComponentModel.DataAnnotations;

namespace DatabaseService.Models
{
  public class User
  {
    public string Id { get; set; } = Guid.NewGuid().ToString();

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

    public bool IsActive { get; set; } = true;

    [MaxLength(250)]
    public string? ImageUrl { get; set; }

    public ICollection<Role> Roles { get; set; } = [];
  }
}