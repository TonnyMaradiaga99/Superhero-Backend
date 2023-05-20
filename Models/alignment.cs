using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Superhero.Models;

public class Alignment
{
    [ForeignKey("Id")]
    public Guid Id { get; set; }

    [Key]
    public Guid aligment_id { get; set; }

    [Required]
    [MaxLength(250)]
    public string alignment_name { get; set; }
    

}