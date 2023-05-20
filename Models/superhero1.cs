using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Superhero.Models;

public class superhero1
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(250)]
    public string superhero_name { get; set; }

    [MaxLength(250)]
    public string full_name { get; set; }

    [ForeignKey("gender_id")]
    public Guid gender_id { get; set; }

    public int? eye_colour_id { get; set; }

    public int? hair_colour_id { get; set; }

    public int? skin_colour_id { get; set; } 

    [ForeignKey("race_id")]
    public Guid races_id{ get; set; }

    [ForeignKey("publisher_id")]
    public Guid publisher_id { get; set; }

    [ForeignKey("alignment_id")]
    public Guid alignment_id { get; set; }

    public int? height { get; set; }

    public int? weight_kg { get; set; }


}