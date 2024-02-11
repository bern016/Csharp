using System;

namespace Activity2
{
    public class Car
    {
        public string Brand { get; set; }

        public string Color { get; set; }

        public int Price { get; set; }

    }

    class Program
    {

        static void Main(string[] args)
        {
            List<Car> list = new List<Car>();

            while (true)
            {

                Console.Write("Enter new data? [Y/N]: ");

                if (Console.ReadLine() == "N")
                {
                    break;
                }

                Car car = new Car();

                Console.Write("Enter Car Brand: ");
                car.Brand = Console.ReadLine();

                Console.Write("Enter Car Color: ");
                car.Color = Console.ReadLine();

                Console.Write("Enter Car Price: ");
                car.Price = int.Parse(Console.ReadLine());

                Console.WriteLine();

                list.Add(car);
            }

            list.ForEach(x =>
            {

                Console.WriteLine(x.Brand);
                Console.WriteLine(x.Color);
                Console.WriteLine(x.Price);


                Console.WriteLine("===============");
                Console.WriteLine();


            });

        }

    }

}

