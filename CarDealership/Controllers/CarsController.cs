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
    public ActionResult Add() {
    //stuff to make new car;
    return RedirectToAction("Index");
    }
    
  }

}