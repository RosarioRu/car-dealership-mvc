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

  //example test below:
  //  [TestMethod]
  //   public void ItemConstructor_CreatesInstanceOfItem_Item()
  //   {
  //     Item newItem = new Item("test");
  //     Assert.AreEqual(typeof(Item), newItem.GetType());
  //   }

  }
}