using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Superhero.Models;

public class Attribute
{
    [ForeignKey("Id")]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(250)]
    public String? attribute_name { get; set; }
}