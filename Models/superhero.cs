using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Superhero.Models;

public class superhero
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(250)]
    public string? superhero_name { get; set; }

    [MaxLength(250)]
    public string? full_name { get; set; }

    [ForeignKey("genders")]
    public Guid genders { get; set; }

    public int? eye_colour_id { get; set; }

    public int? hair_colour_id { get; set; }

    public int? skin_colour_id { get; set; } 

    [ForeignKey("races")]
    public Guid races { get; set; }

    [ForeignKey("publisher_name")]
    public Guid publisher_name { get; set; }

    [ForeignKey("alignments")]
    public Guid alignments { get; set; }

    public int? height { get; set; }

    public int? weight_kg { get; set; }


}