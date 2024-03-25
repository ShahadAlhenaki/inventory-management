namespace sda_onsite_2_inventory_management.src
{

    public class Store
    {
        private string _name;
        private readonly List<Item> _items;

        public Store(string name)
        {
            _name = name;
            _items = [];

        }
        public List<Item> GetItems()
        {
            return _items;
        }

        public bool AddItems(Item newItem)
        {
            _items.Add(newItem);
            return true;
        }
        public bool RemoveItems(Item item)
        {
            _items.Remove(item);
            return true;
        }
    }
}