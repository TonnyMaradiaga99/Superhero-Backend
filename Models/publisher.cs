using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Superhero.Models;

public class publisher
{
    [ForeignKey("Id")]
    public Guid Id { get; set; }

    [Key]
    public Guid publisher_id { get; set; }

    [Required]
    [MaxLength(250)]
    public string publisher_name { get; set; }
    
}