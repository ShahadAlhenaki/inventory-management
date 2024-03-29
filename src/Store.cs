namespace sda_onsite_2_inventory_management.src
{

    public class Store
    {
        private string _name;
        private readonly int _maximumCpacity;
        private readonly List<Item> _items;

        public Store(string name, int maximumCpacity)
        {
            _name = name;
            _maximumCpacity = maximumCpacity;
            _items = [];
        }

        public int GetCurrentVolume()
        {
            int totalVolume = 0;
            foreach (Item item in _items)
            {
                totalVolume += item.GetQuantity();
            }
            return totalVolume;
        }

        public int GetMaximumCapacity()
        {
            return _maximumCpacity;
        }

        public List<Item> GetItems()
        {
            return _items;
        }

        public List<Item> SortByName(SortOrder order)
        {
            if (order == SortOrder.ASC)
            {
                return _items.OrderBy(item => item.GetName()).ToList();
            }
            if (order == SortOrder.DESC)
            {
                return _items.OrderByDescending(item => item.GetName()).ToList();
            }
            return _items;
        }

        public Item? FindByName(string targetItem)
        {
            return _items.Find(item => item.GetName() == targetItem);
        }

        public bool AddItems(Item newItem)
        {
            var availableSpace = GetMaximumCapacity() - GetCurrentVolume();
            //Console.WriteLine($"availableSpace {availableSpace}");
            if (availableSpace < newItem.GetQuantity())
            {
                throw new Exception("Please give me more space to store !!!");
            }

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
            _items.Remove(item);
            return true;
        }

        public Dictionary<char, List<Item>> GroupByName(List<Item> items)
        {
            Dictionary<char, List<Item>> groups = new();

            foreach (var item in items)
            {
                if (!groups.ContainsKey(item.GetName()[0]))
                {
                    groups.Add(item.GetName()[0], []);
                }
                groups[item.GetName()[0]].Add(item);
            }
            return groups;
        }

        public IEnumerable<IGrouping<string, Item>> GroupByDate()
        {
            var grouped = _items.GroupBy(item =>
            {
                double timeDifferenceInDays = (DateTime.Now - item.GetCreatedAt()).TotalDays;
                if (timeDifferenceInDays < 90)
                {
                    return "new";
                }
                else
                {
                    return "old";
                }

            });
            return grouped;
        }
    }
}