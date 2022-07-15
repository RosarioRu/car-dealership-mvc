using System;
using System.Collections.Generic; 


namespace CarDealership.Models
{
  public class Car
  { 
    //properties
    public string MakeModel {get;set;}
    public int Price {get; set;}
    public int Miles {get; set;}

    private static List<Car> _instancesOfCars = new List<Car>{};


    //constructor
    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _instancesOfCars.Add(this);
    }

    //public method to return a list of instances of car 
    public static List<Car> ListAllCars()
    {
      return _instancesOfCars;
    }
    
    //public method to clear lists
    public static void ClearAll()
    {
      _instancesOfCars.Clear();
    }


  }
}