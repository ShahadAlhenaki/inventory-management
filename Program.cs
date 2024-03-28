namespace sda_onsite_2_inventory_management.src;

internal class Program
{
    private static void Main(string[] args)
    {
        Store store = new("tamimi", 5500);

var waterBottle = new Item("Water Bottle", 10, new DateTime(2023, 1, 1));
var chocolateBar = new Item("Chocolate Bar", 15, new DateTime(2023, 2, 1));
var notebook = new Item("Notebook", 5, new DateTime(2023, 3, 1));
var pen = new Item("Pen", 20, new DateTime(2023, 4, 1));
var tissuePack = new Item("Tissue Pack", 30, new DateTime(2023, 5, 1));
var chipsBag = new Item("Chips Bag", 25, new DateTime(2023, 6, 1));
var sodaCan = new Item("Soda Can", 8, new DateTime(2023, 7, 1));
var soap = new Item("Soap", 12, new DateTime(2023, 8, 1));
var shampoo = new Item("Shampoo", 40, new DateTime(2023, 9, 1));
var toothbrush = new Item("Toothbrush", 50, new DateTime(2023, 10, 1));

var coffee = new Item("Coffee", 20);
var sandwich = new Item("Sandwich", 15);
var batteries = new Item("Batteries", 10);
var umbrella = new Item("Umbrella", 5);
var sunscreen = new Item("Sunscreen", 8);

        List<Item> items = store.GetItems();
        Console.WriteLine("count before " + items.Count);
        store.AddItems(waterBottle);
        store.AddItems(chocolateBar);
        store.AddItems(notebook);
        store.AddItems(pen);
        store.AddItems(tissuePack);
        store.AddItems(chipsBag);
        store.AddItems(sodaCan);
        store.AddItems(soap);
        store.AddItems(shampoo);
        store.AddItems(toothbrush);
        store.AddItems(coffee);
        store.AddItems(sandwich);
        store.AddItems(batteries);
        store.AddItems(umbrella);
        store.AddItems(sunscreen);

        Console.WriteLine($"count {items.Count}");
        int page = 1;
        int itemsPerPage = 2;
        int currentPage = (page - 1 )* itemsPerPage;
        var paginated = items
        .Select(i => i)
        .Skip(currentPage)
        .Take(itemsPerPage);

        foreach(var item in paginated)
        {
            Console.WriteLine(item.GetId() + " " +item.GetName());
        }


        // Console.WriteLine($"Current Volume {store.GetCurrentVolume()}");
        // Console.WriteLine($"Max Capacity {store.GetMaximumCapacity()}");

        // Console.WriteLine("count after " + items.Count);

        Item? galaxy = store.FindByName("Galaxy crispy");
        if (galaxy is not null)
        {
            // Console.WriteLine(galaxy.GetName());
            // Console.WriteLine(galaxy.GetQuantity());
            // Console.WriteLine("==================");
        }

        List<Item> sorted = store.SortByName(SortOrder.DESC);

        foreach (var item in sorted)
        {
            // Console.WriteLine(item.GetName());

        }
    }
}

