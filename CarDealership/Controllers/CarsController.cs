using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic; 


namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index() 
    { 
      List<Car> carsAvailable = Car.ListAllCars();
      return View(carsAvailable); }

    [HttpGet("/add")]
    public ActionResult AddCar() { return View(); }

    [HttpPost("/cars")]
    public ActionResult Add(string makeModel, int price, int milage) 
    {
      Car carToAdd = new Car(makeModel, price, milage);
      return RedirectToAction("Index");
    }
    
  }

}