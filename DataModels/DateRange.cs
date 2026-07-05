
using System.ComponentModel.DataAnnotations;

namespace Budget.DataModels;

public class DateRange : RangeAttribute
{
    public DateRange() : base(typeof(DateTime), DateTime.Now.AddYears(-10).ToShortDateString(), DateTime.Now.AddYears(10).ToShortDateString()) { }
}