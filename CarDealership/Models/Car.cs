using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    private static List<Car> _carList = new List<Car>{};
    public string Make { get; set; }
    public string CarModel { get; set; }
    public int Year { get; set; }
    public int Mileage { get; set; }

    public Car (string make, string carModel, int year, int mileage)
    {
      Make = make;
      CarModel = carModel;
      Year = year;
      Mileage = mileage;
      _carList.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _carList;
    }
  }
}