using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Superhero.Models;

public class Hero_attribute
{
    [ForeignKey("Id")]
    public Guid Id { get; set; }

    [Required]
    public int? attribute_id { get; set; }

    public int? attribute_value { get; set; }
    


}