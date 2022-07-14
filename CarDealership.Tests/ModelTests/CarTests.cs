using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CarDealership.Models;
using System;

namespace CarDealership.Tests
{
  [TestClass]
  public class CarTests 
  {
    [TestMethod] //first test
    public void CarConstructor_CreatesAnInstanceOfCar_Car()
    {
      Car newCar = new Car("NissanAltima", 2500, 150000);
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }

    [TestMethod] //second test
    public void GetMakeModel_ReturnsMakeModel_String()
    {
      //arange
      string thisCarMakeModel = "Honda Civic";
      //act
      Car newCar = new Car(thisCarMakeModel, 5000, 60000);
      string result = newCar.MakeModel;
      //assert
      Assert.AreEqual(thisCarMakeModel, result);
    }




  }
}