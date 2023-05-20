using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Superhero.Models;

public class Hero_power
{
    [ForeignKey("Id")]
    public Guid Id { get; set; }

    [Required]
    public int? power_id { get; set; }
    
}