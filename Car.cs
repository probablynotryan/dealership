using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;

  public Car (string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

  public bool WorthBuying(int MaxPrice)
  {
    return (Price <= maxPrice);
  }
}

  public class Program
{
  public static void Main()
  {
    Car volvo = new Car("2012 Volvo Thundergrumbles", 1100, 290134); 
    Car yugo = new Car("1980 Yogo Koral", 700, 56000);
    Car ford = new Car("1988 Ford Country Squire",1400,239001);
    Car chevy = new Car("1910 Chevy Model QuestionMark", 50, 14823940000);
    
    List<Car> Cars = new List<Car>() { volvo, yugo, ford, chevy };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach(Car automobile in Cars)
    {
      if(automobile.WorthBuying(maxPrice))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }
    
    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }
  } 
}