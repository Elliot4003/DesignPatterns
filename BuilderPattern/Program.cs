using BuilderPattern.Builders;
using BuilderPattern.Products;
using System.Reflection;

namespace BuilderPattern;

public class Program
{
    static void Main(string[] args)
    {
        var director = new Director();
        var builder = new VehicleBuilder();
        director.Builder = builder;

        director.BuildMilleniumFalcon();
        var milleniumFalcon = builder.GetVehicle();

        PropertyInfo[] properties = typeof(Vehicle).GetProperties();

        Console.WriteLine($"{milleniumFalcon.Name} créé !");
        foreach(var property in properties)
        {
            Console.WriteLine($"{property.Name} : {property.GetValue(milleniumFalcon)}");
        }

        Console.WriteLine();
        director.BuildTIEFighter();
        var tieFighter = builder.GetVehicle();

        Console.WriteLine($"{tieFighter.Name} créé !");
        foreach (var property in properties)
        {
            Console.WriteLine($"{property.Name} : {property.GetValue(tieFighter)}");
        }

        Console.WriteLine();
        director.BuildARTT();
        var artt = builder.GetVehicle();

        Console.WriteLine($"{artt.Name} créé !");
        foreach (var property in properties)
        {
            Console.WriteLine($"{property.Name} : {property.GetValue(artt)}");
        }

    }
}

