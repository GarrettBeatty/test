namespace Test1;

public class Zoo
{
    public string Name { get; set; }
    private List<Animal> animals = new List<Animal>();

    public Zoo(string name)
    {
        Name = name;
    }

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
        Console.WriteLine($"Added {animal.Name} to {Name}");
    }

    public void ShowAllAnimals()
    {
        Console.WriteLine($"\n=== {Name} Animals ===");
        foreach (var animal in animals)
        {
            Console.WriteLine($"- {animal}");
            Console.WriteLine($"  Sound: {animal.MakeSound()}");
        }
    }

    public int GetAnimalCount()
    {
        return animals.Count;
    }
}
