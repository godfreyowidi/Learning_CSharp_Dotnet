using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

var fileContent = await File.ReadAllTextAsync("data.json");
var cars = JsonSerializer.Deserialize<CarData[]>(fileContent);


// Print all cars with atleast 4 doors
// var carsWithAtleastFourDoors = cars.Where(car => car.NumberOfDoors >= 4);
// foreach(var car in carsWithAtleastFourDoors)
// {
//     Console.WriteLine($"The car {car.Model} has {car.NumberOfDoors} doors");
// }

// Print all Mazda cars with atleast 4 doors
// var mazdasWithAtleastFourDoors = cars.Where(car => car.NumberOfDoors >= 4 && car.Make == "Mazda");
// mazdasWithAtleastFourDoors = cars.Where(car => car.NumberOfDoors >= 4).Where(car => car.Make == "Mazda");
// foreach(var car in mazdasWithAtleastFourDoors)
// {
//     Console.WriteLine($"The Mazda car {car.Model} has {car.NumberOfDoors} doors");
// }

// Print Make + Model for all Makes that start with "M
// cars.Where(car => car.Make.StartsWith("M"))
//     .Select(car => $"{car.Make} {car.Model}")
//     .ToList()
//     .ForEach(car => Console.WriteLine(car));

// Display a list of the 10 most powerful cars (in terms of hp)
// cars.OrderByDescending(car => car.HP)
//     .Take(10)
//     .Select(car => $"{car.Make} {car.Model}")
//     .ToList()
//     .ForEach(car => Console.WriteLine(car));

// Display the number of Models per Make that appeared after 2008
// Makes should be displayed with a number of zero if there are no models after 2008
// cars.GroupBy(car => car.Make)
//     .Select(c => new { c.Key, 
//         NumberOfModels = c.Count(car => car.Year >= 2008) })
//     .ToList()
//     .ForEach(item => Console.WriteLine($"{item.Key}: {item.NumberOfModels}"));

// Display a list of makes that have atleast two models with >= 400hp
// cars.Where(car => car.HP >= 400)
//     .GroupBy(car => car.Make)
//     .Select(car => new { Make = car.Key, NumberOfPowerfulCars = car.Count() })
//     .Where(make => make.NumberOfPowerfulCars >= 2)
//     .ToList()
//     .ForEach(make => Console.WriteLine(make.Make));

// Display the average HP per make
// cars.GroupBy(car => car.Make)
//     .Select(car => new { Make = car.Key, AverageHP = car.Average(c => c.HP) })
//     .ToList()
//     .ForEach(make => Console.WriteLine($"{make.Make}: {make.AverageHP}"));

// How many makes build cars with hp between 0..100, 101..200, 201..300, 401..500
cars.GroupBy(car => car.HP switch
    {
        <= 100 => "0..100",
        <= 200 => "101..200",
        <= 300 => "201..300",
        <= 400 => "301..400",
        _ => "401..500"
    })
    .Select(car => new { HPCategory = car.Key, 
        NumberOfMake = car.Select(c => c.Make).Distinct().Count() })
    .ToList()
    .ForEach(item => Console.WriteLine($"{item.HPCategory}: {item.NumberOfMake} "));
class CarData
{
    [JsonPropertyName("id")]
    public int ID { get; set;}

    [JsonPropertyName("car_make")]
    public string Make { get; set;}

    [JsonPropertyName("car_model")]
    public string Model { get; set;}

    [JsonPropertyName("car_year")]
    public int Year { get; set;}

    [JsonPropertyName("number_of_doors")]
    public int NumberOfDoors { get; set;}

    [JsonPropertyName("hp")]
    public int HP { get; set;}
    
}





// var even = true;

// var result = GenerateNumbers(10);
// if (even)
// {
//     result = result.Where(n => n % 2 == 0);
// }

// result = result.OrderByDescending(n => n);

// result = result.Select(n => n * 3);

// Console.WriteLine(result.Count());

// foreach (var item in result)
// {
//     Console.WriteLine(item);
// }

// IEnumerable<int> GenerateNumbers(int maxValue)
// {
    
//     for(var i = 0; i <= maxValue; i++)
//     {
//         yield return i;
//     }
// }
