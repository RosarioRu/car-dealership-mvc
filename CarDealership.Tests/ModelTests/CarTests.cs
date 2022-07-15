using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CarDealership.Models;
using System;

namespace CarDealership.Tests
{
  [TestClass]
  public class CarTests : IDisposable
  {
    public void Dispose()
    { 
      Car.ClearAll();
    }

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

    [TestMethod]
    public void SetMakeModel_SetsMakeModel_String()
    {
      //arrange
      string thisOnesMakeModel = "Toyota Sienna";
      Car newCar = new Car(thisOnesMakeModel, 6500, 89000);
      //act
      string changeMakeModelTo = "Toyota Sienna SE";
      newCar.MakeModel = changeMakeModelTo;
      string result = newCar.MakeModel;
      //assert
      Assert.AreEqual(changeMakeModelTo, result);
    }

    [TestMethod]
    public void ListAllCars_ReturnsEmptyList_CarsList()
    {
      //arrange
      List<Car> newList = new List<Car> {};
      //act
      List<Car> instanceList = Car.ListAllCars();
      //assert
      CollectionAssert.AreEqual(newList, instanceList);
    }




  }
}