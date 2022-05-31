namespace Warehouse
{
    public class Item
    {
        public string itemName { get; }
        public decimal itemPrice { get; set; }

        public Item(string name, decimal price)
        {
            itemName = name;
            itemPrice = price;
        }
    }
}


