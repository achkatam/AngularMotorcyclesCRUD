namespace MotorcyclesAPI.Common;

using System.ComponentModel.DataAnnotations;

public class CurrentYearRangeAttribute : ValidationAttribute
{
    private readonly int _minYear;

    public CurrentYearRangeAttribute(int minYear)
    {
        _minYear = minYear;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is int year)
        {
            if (year < _minYear || year > DateTime.Today.Year)
            {
                return new ValidationResult($"Year must be between {_minYear} and {DateTime.Today.Year}.");
            }
        }

        return ValidationResult.Success;
    }
}