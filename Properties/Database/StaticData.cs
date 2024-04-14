using RestApp.Properties.Models;

namespace RestApp.Properties.Database;

public class StaticData
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal(),
        new Animal(),
        new Animal(),
    };
}