using Day1.Filters;
using Day1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Day1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarsController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Car>> GetAll()
    {
        return Car.GetCars();
    }

    [HttpGet]
    [Route("{id:int}")]

    public ActionResult<Car> GetById(int id) 
    {
        var car = Car.GetCars().FirstOrDefault(c => c.Id == id);
        if(car == null)
        {
            return NotFound( new GeneralResponse("Car Not Found !!!"));      
        }

        return car;
    }
    [HttpPost]
    [Route("v1")]
    public ActionResult Add(Car car)
    {
        car.Type = "Gas";
        Car.GetCars().Add(car);
        return CreatedAtAction(
            actionName: nameof(GetById),
            routeValues: new { id = car.Id },
            value: new GeneralResponse("Car is added Successfully")
         );
    }

    [HttpPost]
    [Route("v2")]
    [ServiceFilter(typeof(ValidateCarTypeAttribute))]
    public ActionResult AddV2(Car car)
    {
        Car.GetCars().Add(car);
        return CreatedAtAction(
            actionName: nameof(GetById),
            routeValues: new { id = car.Id },
            value: new GeneralResponse("Car is added Successfully")
         );
    }
   

    [HttpPut]
    [Route("{id:int}")]
    public ActionResult Update(Car car ,int id)
    {
        if(id != car.Id)
        {
            return BadRequest(new GeneralResponse("Ids don't match"));
        }
        var updatedCar = Car.GetCars().FirstOrDefault(c => c.Id == id);
        if(updatedCar == null)
        {
            return NotFound(new GeneralResponse("Car Not Found !!!"));
        }

        updatedCar.Id = car.Id;
        updatedCar.Name = car.Name;
        updatedCar.ProductionDate = car.ProductionDate;

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    public ActionResult Delete(int id) 
    {
        var car = Car.GetCars().FirstOrDefault(c => c.Id == id);
        if (car == null)
        {
            return NotFound(new GeneralResponse("Car Not Found !!!"));
        }
        Car.GetCars().Remove(car);
        return NoContent();
    }
}

