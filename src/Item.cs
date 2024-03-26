namespace sda_onsite_2_inventory_management.src
{
    public class Item
    {
        private readonly string _name;
        private readonly int _quantity;
        private readonly DateTime _createdAt;

        public Item(string name, int quantity)
        {
            _name = name;
            _quantity = quantity;
            _createdAt = DateTime.Now;
        }

        public string GetName()
        {
            return _name;
        }

        public DateTime GetCreatedAt()
        {
            return _createdAt;
        }

        public int GetQuantity()
        {
            return _quantity;
        }
    }
}