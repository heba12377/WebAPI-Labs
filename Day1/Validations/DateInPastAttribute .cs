using System.ComponentModel.DataAnnotations;

namespace Day1.Validations;

 public class DateInPastAttribute : ValidationAttribute
 { 
              // date is an object from DateTime
    public override bool IsValid(object? value) => value is DateTime date && date <= DateTime.Now;

 }

