namespace sda_onsite_2_inventory_management.src;

internal class Program
{
    private static void Main(string[] args)
    {
        Store store = new("tamimi");
        Item iceCream = new("vanilla ice cream", 1000);
        Item chocolate = new("Galaxy crispy", 1000);
        Item cookies = new("chocolate chips", 2000);
        Item cookies2 = new("vanilla chips", 2000);
        Item chocolate2 = new("Galaxy milk chocolate", 1000);

        List<Item> items = store.GetItems();
        Console.WriteLine("count before " + items.Count);

        store.AddItems(chocolate);
        store.AddItems(chocolate2);
        store.AddItems(cookies);
        store.AddItems(cookies2);
        store.AddItems(iceCream);

        Console.WriteLine("count after " + items.Count);

        // foreach (Item item in items)
        // {
        //     Console.WriteLine("==================");
        //     Console.WriteLine($"name = {item.GetName()} CREATED_AT = {item.GetCreatedAt()} quantity = {item.GetQuantity()}");
        // }

        Item? galaxy = store.FindByName("Galaxy crispy");
        if (galaxy is not null)
        {
            Console.WriteLine(galaxy.GetName());
            Console.WriteLine(galaxy.GetQuantity());
            Console.WriteLine("==================");
        }

        List<Item> sorted = store.SortByNameAsc();

        foreach (var item in sorted)
        {
            Console.WriteLine(item.GetName());

        }

    }
}

