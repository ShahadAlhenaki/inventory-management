namespace sda_onsite_2_inventory_management.src
{
    public class Item
    {
        private readonly string _name;
        private int _quantity;
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Quantity cannot be negative!");
                }
                else
                {
                    _quantity = value;
                }
            }
        }
        private readonly Guid _id = Guid.NewGuid();
        private readonly DateTime _createdAt;

        public Item(string name, int quantity)
        {
            _name = name;
            Quantity = quantity;
            _createdAt = DateTime.Now;
        }
        public Item(string name, int quantity, DateTime createdAt)
        {
            _name = name;
            Quantity = quantity;
            _createdAt = createdAt;
        }

        public string GetName()
        {
            return _name;
        }

        public Guid GetId()
        {
            return _id;
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