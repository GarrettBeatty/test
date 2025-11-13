namespace Test1;

public class VeterinaryClinic
{
    public string ClinicName { get; set; }
    private List<Animal> patients = new List<Animal>();

    public VeterinaryClinic(string clinicName)
    {
        ClinicName = clinicName;
    }

    public void CheckIn(Animal animal)
    {
        patients.Add(animal);
        Console.WriteLine($"{animal.Name} checked in at {ClinicName}");
    }

    public void PerformCheckup(Animal animal)
    {
        Console.WriteLine($"\nPerforming checkup on {animal}...");
        Console.WriteLine($"  Health Status: Good");
        Console.WriteLine($"  Vaccination: Up to date");
        Console.WriteLine($"  {animal.Name} says: {animal.MakeSound()}");
    }

    public void ShowPatients()
    {
        Console.WriteLine($"\n=== {ClinicName} Patients ===");
        foreach (var patient in patients)
        {
            Console.WriteLine($"- {patient}");
        }
    }
}
