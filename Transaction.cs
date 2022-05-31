namespace Warehouse
{
    public class Transaction
    {
        public Dictionary<Item, int> Items { get; set; }
        public DateTime DateTime { get; set; }

        public Account Buyer{ get; set; }

        public Account Seller{ get; set; }

        public Transaction(
            Dictionary<Item, int> items,
            DateTime dateTime,
            Account buyer,
            Account seller
        ) {
            Items = items;
            DateTime = dateTime;
            Buyer = buyer;
            Seller = seller;
        }

    }
}