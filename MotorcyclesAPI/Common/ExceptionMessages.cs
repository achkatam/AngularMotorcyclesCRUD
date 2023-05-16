namespace MotorcyclesAPI.Common;
 
public static class ExceptionMessages
{
    public const string WRONG_ID = "Id cannot be 0 or less.";
    public const string WRONG_MAKE = "Make cannot be null or empty.";
    public const string WRONG_MODEL = "Model cannot be null or empty.";
    public const string WRONG_YEAR = $"Year cannot be less than 1900.";
    public const string WRONG_PRICE = "Price cannot be 0 or less.";
}