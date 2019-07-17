using System;

namespace Dealership.Models
{

  class Car
  {
    private string _MakeModel;
    private int _Price;
    private int _Miles;
    private string _Message;

    public Car(string makeModel, int price, int miles, string message)
    {
      _MakeModel = makeModel;
      _Price = price;
      _Miles = miles;
      _Message = message;
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }
    
    public string GetMakeModel()
       {
         return _MakeModel;
       }
    public string GetMessage()
    {
      return _Message;
    }
    public int GetPrice()
    {
      return _Price;
    }
    public int GetMiles()
    {
      return _Miles;
    }

    public void SetPrice(int newPrice)
    {
      _Price = newPrice;
    }

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return (_Price < maxPrice && _Miles < maxMiles);
    }
  }
}
