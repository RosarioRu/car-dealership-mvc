using System;
//using System.Collections.Generic; (for lists)


namespace CarDealership.Models
{
  public class Car
  { 
    //properties
    public string MakeModel {get;set;}
    public int Price {get; set;}
    public int Miles {get; set;}

    //constructor
    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }


  }
}