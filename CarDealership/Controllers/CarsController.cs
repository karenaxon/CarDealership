using System.Security.AccessControl;
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
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string make, string carModel, int year, int mileage)
    {
      Car myCar = new Car(make, carModel, year, mileage);
      return RedirectToAction("Index");
    }
  }
}