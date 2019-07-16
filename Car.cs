using System;
using System.Collections.Generic;

class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
  public string Message;

  public Car(string makeModel, int price, int miles, string message)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
    Message = message;
  }

  public bool WorthBuying(int maxPrice, int maxMiles)
  {
    return (Price < maxPrice && Miles < maxMiles);
  }
}

public class Program
{
  public static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "Come look at this awesome old VW!");
    Car yugo = new Car("1980 Yugo Koral", 700, 56000, "What is a Yugo anyways?");
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "Good old Ford");
    Car amc = new Car("1976 AMC Pacer", 400, 198000, "Real old car");

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum mileage: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice, maxMiles))
      {
        CarsMatchingSearch.Add(automobile);
      } 
    }

    if (CarsMatchingSearch.Count == 0)
    {
      Console.WriteLine("No cars match your criteria.");
    }
    else
    {
      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine(automobile.MakeModel + "-" + automobile.Message);
      }
    }
  }
}
