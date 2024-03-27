namespace sda_onsite_2_inventory_management.src;

internal class Program
{
    private static void Main(string[] args)
    {
        Store store = new("tamimi", 500);
        Item iceCream = new("vanilla ice cream", 50);
        Item chocolate = new("Galaxy crispy", 440);
        Item cookies = new("chocolate chips", 20);
        Item cookies2 = new("vanilla chips", 60);
        Item chocolate2 = new("Galaxy milk chocolate", 50);

        List<Item> items = store.GetItems();
        Console.WriteLine("count before " + items.Count);

        store.AddItems(chocolate);
        store.AddItems(chocolate2);
        store.AddItems(cookies);
        store.AddItems(cookies2);
        store.AddItems(iceCream);

        Console.WriteLine($"Current Volume {store.GetCurrentVolume()}");
        Console.WriteLine($"Max Capacity {store.GetMaximumCapacity()}");

        Console.WriteLine("count after " + items.Count);

        Item? galaxy = store.FindByName("Galaxy crispy");
        if (galaxy is not null)
        {
            Console.WriteLine(galaxy.GetName());
            Console.WriteLine(galaxy.GetQuantity());
            Console.WriteLine("==================");
        }

        List<Item> sorted = store.SortByName(SortOrder.DESC);

        foreach (var item in sorted)
        {
            Console.WriteLine(item.GetName());

        }
    }
}

