using System;

class Menu
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Orders
{
        List<Menu> orders = new List<Menu>();
    
    public void AddItem(string name, double price)
    {   
        orders.Add(new Menu
        { Name = name, Price = price });
        Console.WriteLine();
        Console.WriteLine(name+" added to the order.");
    }

    public void ViewOrderSummary()
    {
        if (orders.Count() == 0)
        {
            Console.WriteLine("Order is empty.");
        }
        else
        {
            Console.WriteLine("\nOrder Summary:");
            orders.ForEach(item =>
            {
                Console.WriteLine(""+item.Name +" : " + item.Price);
              
            });
        }
    }

    public void PlaceOrder()
    {
        if (orders.Count == 0)
        {
            Console.WriteLine("Order is empty.");
        }
        else
        {
            double total = 0;
            orders.ForEach(item =>
            {
                total += item.Price;
            });
            Console.WriteLine($"\nTotal Price of Order: ${total}");
            Console.WriteLine("Order served. List cleared.");
            orders.Clear();

        }
    }
}


class Program
{
    static void Main(String[] args)
    {
        Orders ord = new Orders();
       
        Console.WriteLine("Ordering System Menu:\n");
        Console.WriteLine("1. Add Item to Order");
        Console.WriteLine("2. View Order Summary");
        Console.WriteLine("3. Place Order");
        Console.WriteLine("4. Exit\n");


        while (true)
        {
            Console.WriteLine();
            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();


            switch (choice)
            {
               case "1": Console.Write("Enter Item: ");
                   
                    string itemName = Console.ReadLine();

                    Console.Write("Price: ");
                    double itemPrice = double.Parse(Console.ReadLine());
                  
                    ord.AddItem(itemName, itemPrice);
                    break;

                case "2":
                     ord.ViewOrderSummary();
                    break;

                case "3":
                    ord.PlaceOrder();
                    break;

                case "4":
                    Console.WriteLine("Exiting the ordering system. Goodbye!");
                    return;
                    break;

            }


        }


    }

}
