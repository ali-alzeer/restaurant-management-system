using System.ComponentModel.DataAnnotations;

namespace DatabaseService.Models
{
  public class Reservation
  {
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [Required]
    [MaxLength(36), MinLength(36)]
    public required string TableId { get; set; }
    [Required]
    public required Table Table { get; set; }

    [Required]
    public required DateTime StartDate { get; set; } = DateTime.Now;
    [Required]
    public required DateTime EndDate { get; set; } = DateTime.Now;
  }
}