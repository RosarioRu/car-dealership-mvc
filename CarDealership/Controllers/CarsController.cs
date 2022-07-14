using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index() { return View(); }

    [HttpGet("/add")]
    public ActionResult AddCar() { return View(); }

    [HttpPost("/cars")]
    public ActionResult Add() {
    //stuff to make new car;
    return RedirectToAction("Index");
    }
    
  }

}