using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
  {
    public class Program
    {
      public static void Main()
      {
        Car volvo = new Car("2012 Volvo Thundergrumbles", 1100, 290134, 420); 
        Car yugo = new Car("1980 Yogo Koral", 700, 56000, 250);
        Car ford = new Car("1988 Ford Country Squire",1400,239001, 100);
        Car chevy = new Car("1910 Chevy Model QuestionMark", 50, 14823, 2);
        
        List<Car> Cars = new List<Car>() { volvo, yugo, ford, chevy };
        
        volvo.SetPrice(500);
        Console.WriteLine(Car.MakeSound("Vroom!"));

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
          Console.WriteLine("------------------------------");
          Console.WriteLine(automobile.MakeModel);
          Console.WriteLine(automobile.Miles + " miles");
          Console.WriteLine("$"+automobile.Price);
          Console.WriteLine(automobile.HorsePower + " HP");
        }
      }
    }
  }