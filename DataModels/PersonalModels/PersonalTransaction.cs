using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Budget.DataModels.PersonalModels;

public class PersonalTransaction
{
    [Key]
    public int Id { get; set; }

    [Required, NotNull, Length(3, 30)]
    public string? Name { get; set; }

    [Required, NotNull, Range(0, 5000)]
    public double Amount { get; set; }

    [Required, NotNull, DateRange]
    public DateTime Date { get; set; }

    [Required, NotNull]
    public int CategoryId { get; set; }

    [JsonIgnore]
    public PersonalCategory? Category { get; set; }
}