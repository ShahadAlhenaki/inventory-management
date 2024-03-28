namespace sda_onsite_2_inventory_management.src
{
    public class Item
    {
        private readonly string _name;
        private readonly int _quantity;
        // static private int _id = 0;
        private readonly DateTime _createdAt;

        public Item(string name, int quantity)
        {
            _name = name;
            _quantity = quantity;
            // _id = _id + 1;
            _createdAt = DateTime.Now;
        }
        public Item(string name, int quantity, DateTime createdAt)
        {
            _name = name;
            _quantity = quantity;
            // _id = _id + 1;
            _createdAt = createdAt;
        }

        public string GetName()
        {
            return _name;
        }

        // public int GetId()
        // {
        //     return _id;
        // }

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