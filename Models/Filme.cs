using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
  public class Filme
  {
    public int id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    [KeyAttribute]
    [Display(Name = "Título")]
    public string titulo { get; set; }

    [Display(Name = "Data de lançamento")]
    [DataType(DataType.Date)]
    public DateTime lancamento { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]
    public string genero { get; set; }

    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal preco { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    [StringLength(5)]
    [Required]
    public string classificacao { get; set; }

  }
}
