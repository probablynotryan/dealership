namespace Dealership.Models
{
  public class Car
  {
    private int _year;
    private string _makeModel;
    private double _price;
    private int _miles;
    private int _horsepower;

    public Car(int year, string makeModel, double price, int miles, int horsepower)
    {
      _year = year;
      _makeModel = makeModel;
      _price = price *(.2);
      _miles = miles;
      _horsepower = horsepower;
    }
    
    public static string MakeSound(string sound)
    {
      return "Car goes " + sound; 
    }

    public static string ResaleByYear(int Year)
    {
      if(Year > 2000)
      {
        return "Less than you paid, but you could still get a decent price for this car.";
      }
      else if(Year >= 1980)
      {
        return "You would get a low resale price for this car.";
      }
      else 
      {
        return "Your better off selling this car for scrap metal.";
      }
    }
    public static string CheckHorsePower(int Horsies)
    {
      if (Horsies > 249)
      { 
        return "This car is fast enough fer dem Silly-Billy Rally!";
      }
      else 
      { 
        return "This car ain't fast enough fer dem Rallies!";
      }
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public string MakeModel
    {
      get
      {
      return _makeModel;
      }
      set
      {
        _makeModel = value;
      }
    }
    
    public int Year
    {
      get
      {
        return _year;
      }
      set
      {
        _year = value;
      }
    }

    public int HorsePower
    {
      get
      {
      return _horsepower;
      }
      set
      {
        _horsepower = value;
      }
    }

    public double Price
    {
      get
      {
      return _price;
      }
      set
      {
        _price = value;
      }
    }

    public int Miles
    {
      get
      {
      return _miles;
      }
      set
      {
        _miles = value;
      }
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price <= maxPrice);
    }
  }
}