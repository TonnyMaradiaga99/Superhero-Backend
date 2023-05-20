using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Superhero.Models;

public class alignment
{
    [ForeignKey("Id")]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(250)]
    public string? alignments { get; set; }
    

}