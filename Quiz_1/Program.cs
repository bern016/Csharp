using System;


class Person
{
    public string Name { get; set; }
    public int Weight { get; set; }
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>();

        Console.WriteLine("Type 'end' to finish.");

        while (true)
        {
            Person person = new Person();

            Console.Write("Enter person's name: ");
            string inputName = Console.ReadLine();

            if (inputName == "end")
            {
                break;
            }

            person.Name = inputName;

            Console.Write("Enter person's weight: ");
            person.Weight = int.Parse(Console.ReadLine());


            Console.WriteLine();
            people.Add(person);
        }

        Console.WriteLine("\nList of People:");
        people.ForEach(x =>
        {
            Console.WriteLine("Name: " + x.Name);
            Console.WriteLine("Weight: " + x.Weight);

            Console.WriteLine();
        });

        int totalWeight = 0;
        people.ForEach(x =>
        {
            totalWeight += x.Weight;
        });

        Console.WriteLine($"\nTotal Weight of All People: {totalWeight}");
    }
}