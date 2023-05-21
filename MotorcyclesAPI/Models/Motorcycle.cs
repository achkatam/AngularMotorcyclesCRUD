namespace MotorcyclesAPI.Models;

using System.ComponentModel.DataAnnotations;

using Common;
using Utilities;

public class Motorcycle
{
    public Motorcycle(string model, string make, int year, decimal price)
    {
        Model = model;
        Make = make;
        Year = year;
        Price = price;
    }

    [Key]
    public int Id { get;set;}

    [Required]
    [StringLength(ValidationConstants.MOTORCYCLE_MAKE_MAX,ErrorMessage = "Max length for Make is 75 chars, cannot be null or empty", MinimumLength = ValidationConstants.MOTORCYCLE_MAKE_MIN)]
    public string Make { get; set; }

    [Required]
    [StringLength(ValidationConstants.MOTORCYCLE_MODEL_MAX, ErrorMessage = "Max length for Model is 75 chars, cannot be null or empty", MinimumLength = ValidationConstants.MOTORCYCLE_MODEL_MIN)]
    public string Model { get; set; }

    [Required]
    [CurrentYearRange(ValidationConstants.MOTORCYCLE_YEAR_MIN)]
    public int Year { get; set; }

    [Required]
    [Range((double)ValidationConstants.MOTORCYCLE_PRICE_MIN, (double)ValidationConstants.MOTORCYCLE_PRICE_MAX)]
    public decimal Price { get; set; }
     
}