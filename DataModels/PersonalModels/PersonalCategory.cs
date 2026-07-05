using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Budget.DataModels.PersonalModels;

public class PersonalCategory
{
    [Key]
    public int Id { get; set; }

    [Required, NotNull, Length(3, 30)]
    public string? Name { get; set; }

    private int _numberOfTransaction;
    public int NumberOfTransaction { get { _numberOfTransaction = Transactions == null ? _numberOfTransaction : Transactions.Count; return _numberOfTransaction; } set { _numberOfTransaction = value; } }

    private double _totalAmount;
    public double TotalAmount { get { _totalAmount = Transactions == null ? _totalAmount : Transactions.Sum(x => x.Amount); return Math.Round(_totalAmount, 2); } set { _totalAmount = value; } }

    public ICollection<PersonalTransaction>? Transactions { get; set; }
}