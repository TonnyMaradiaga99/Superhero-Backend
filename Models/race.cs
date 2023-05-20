using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Superhero.Models;

public class race
{
    [ForeignKey("Id")]
    public Guid Id { get; set; }

    [Key]
    public Guid race_id { get; set; }

    [Required]
    [MaxLength(250)]
    public string races { get; set; }
    
}