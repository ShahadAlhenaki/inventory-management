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

        public List<Item> SortByNameAsc()
        {
            return _items.OrderBy(item => item.GetName()).ToList();
        }

        public Item? FindByName(string targetItem)
        {
            return _items.Find(item => item.GetName() == targetItem);
        }

        public bool AddItems(Item newItem)
        {
            bool foundItem = _items.Contains(newItem);
            if (!foundItem)
            {
                _items.Add(newItem);
                return true;
            }
            return false;
        }

        public bool RemoveItems(Item item)
        {
            // check the new item has the same name with the item in the array _items or not  Find() or Any()
            // if not, then remove item to array 
            // if yes, throw error or return false
            _items.Remove(item);
            return true;
        }
    }
}