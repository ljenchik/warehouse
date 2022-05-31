namespace Warehouse
{
    public class Transaction
    {
        public Dictionary<Item, int> stock { get; set; }
        public DateTime dateTime { get; set; }

        public Account from { get; set; }

        public Account to { get; set; }

        public decimal price { get; set; }


    }
}