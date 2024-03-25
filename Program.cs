namespace sda_onsite_2_inventory_management.src;


internal class Program
{
    private static void Main(string[] args)
    {
        Store store = new("tamimi");
        Item chocolate = new("Galaxy crispy", 1000);
        Item cookies = new("chocolate chips", 2000);

        List<Item> items = store.GetItems();
        Console.WriteLine("count before" + items.Count);


        store.AddItems(chocolate);
        store.AddItems(cookies);
        Console.WriteLine("count after" + items.Count);

        foreach (Item item in items)
        {
            Console.WriteLine("==================");
            Console.WriteLine($"name = {item.GetName()} CREATED_AT = {item.GetCreatedAt()} quantity = {item.GetQuantity()}");
        }

    }
}

