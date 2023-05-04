namespace MotorcyclesAPI.Models;

public class Motorcycle
{
    public int Id { get; set; }
    public string Make { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Year { get; set; } = string.Empty;

    public decimal Price { get; set; }
}