using Day1.Validations;
using System.ComponentModel.DataAnnotations;

namespace Day1.Models;

public class Car
{
    public int Id { get; set; }

    [Required]
    [StringLength(10, MinimumLength = 3, ErrorMessage = "{0} is betweene {2} and {1}")]
    public string Name { get; set; } = string.Empty;

    [DateInPast]  // custom validation
    public DateTime ProductionDate { get; set; }

    //new attribute   ===>  added action filter
    public string Type { get; set; } = string.Empty;

    public Car(int  id, string name, DateTime productionDate)
    {
        Id = id;
        Name = name;
        ProductionDate = productionDate;
    }
    private static List<Car> _cars = new List<Car>
    {
        new (1, "Volvo",new DateTime(1927,1,8)),
        new (2, "Volkswagen",new DateTime(1938,5,12)),
        new (3, "BMW",new DateTime(1927,3,12)),
        new (4, "Toyota",new DateTime(1936, 5, 8)),
        new (5, "Ford",new DateTime(1903, 5, 8)),
        new (6, "Mercedes-Benz", new DateTime(1926, 5, 8))
    };

    public static List<Car> GetCars() => _cars;

}

