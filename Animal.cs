namespace Test1;

public class Animal
{
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }

    public Animal(string name, string species, int age)
    {
        Name = name;
        Species = species;
        Age = age;
    }

    public string MakeSound()
    {
        return Species.ToLower() switch
        {
            "dog" => "Woof!!!!!",
            "cat" => "Meow!",
            "lion" => "Roar!",
            "elephant" => "Trumpet!",
            _ => "..."
        };
    }

    public override string ToString()
    {
        return $"{Name} the {Species} ({Age} years old)";
    }
}
