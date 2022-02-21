namespace Dealership.Models
{
  public class Car
  {
    private string _makeModel;
    private double _price;
    private int _miles;
    private int _horsepower;

    public Car(string makeModel, double price, int miles, int horsepower)
    {
      _makeModel = makeModel;
      _price = price *(.2);
      _miles = miles;
      _horsepower = horsepower;
    }
    
    public static string MakeSound(string sound)
    {
      return "Car goes " + sound; 
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