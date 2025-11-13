using Test1;

Console.WriteLine("=== Animal Management System ===\n");

// Create some animals
var lion = new Animal("Simba", "Lion", 5);
var elephant = new Animal("Dumbo", "Elephant", 8);
var dog = new Animal("Buddy", "Dog", 3);
var cat = new Animal("Whiskers", "Cat", 2);

// Use Animal class in Zoo
var zoo = new Zoo("City Zoo");
zoo.AddAnimal(lion);
zoo.AddAnimal(elephant);
zoo.ShowAllAnimals();

Console.WriteLine($"\nTotal animals in zoo: {zoo.GetAnimalCount()}");

// Use Animal class in VeterinaryClinic
var clinic = new VeterinaryClinic("Happy Paws Veterinary Clinic");
clinic.CheckIn(dog);
clinic.CheckIn(cat);

clinic.PerformCheckup(dog);
clinic.PerformCheckup(cat);

clinic.ShowPatients();

Console.WriteLine("\nProgram completed successfully!");
