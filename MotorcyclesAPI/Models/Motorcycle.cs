namespace MotorcyclesAPI.Models;

using Common;

public class Motorcycle
{
    private readonly int _id;
    private readonly string _model;
    private readonly string _make;
    private readonly string _year;
    private decimal _price;

    public Motorcycle(string model, string make, string year, decimal price)
    {
        Model = model;
        Make = make;
        Year = year;
        Price = price;
    }

    public int Id
    {
        get { return _id; }
        private init
        {
            if (value <= 0)
            {
                throw new ArgumentException(ExceptionMessages.WRONG_ID);
            }

            _id = value;
        }
    }

    public string Make
    {
        get { return _make; }
        private init
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ExceptionMessages.WRONG_MAKE);
            }

            _make = value;
        }
    }

    public string Model
    {
        get { return _model; }
        private init
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ExceptionMessages.WRONG_MODEL);
            }

            _model = value;
        }
    }

    public string Year
    {
        get { return _year; }
        private init
        {
            if (string.IsNullOrWhiteSpace(value) || int.Parse(value) <= 1900)
            {
                throw new ArgumentException(ExceptionMessages.WRONG_YEAR);
            }

            _year = value;
        }
    }

    public decimal Price
    {
        get { return _price; }
        internal set
        {
            if (value <= 0)
            {
                throw new ArgumentException(ExceptionMessages.WRONG_PRICE);
            }

            _price = value;
        }
    }
}