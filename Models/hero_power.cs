using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Superhero.Models;

public class hero_power
{
    [ForeignKey("Id")]
    public Guid Id { get; set; }

    [Key]
    public Guid power_id { get; set; }
    
}