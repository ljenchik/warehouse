namespace Warehouse
{
    public class Warehouse
    {
        public Dictionary<Item, int> Stock { get; } = new Dictionary<Item, int>();
        public Account Account { get;  } = new Account();
        public Transaction Transaction { get; set; }
        public List<Transaction> Transactions { get; } = new List<Transaction>();

        public Warehouse(Dictionary<Item, int> initialStock)
        {
            Stock = initialStock;
        }
        public void SellItem(CustomerBasket customerBasket, Account buyer)
        {
            foreach (Item item in customerBasket.Contents.Keys)
            {
                if (!Stock.ContainsKey(item))
                {
                    throw new ArgumentOutOfRangeException($"This {item} is not in stock.");
                }
                if (Stock[item] < customerBasket.Contents[item])
                {
                    throw new ArgumentOutOfRangeException($"Attemted to buy more of an {item} than are in stock.");
                }
            }
            foreach (Item item in customerBasket.Contents.Keys)
            {
                Stock[item] -= customerBasket.Contents[item];
            }

            Account.Amount += customerBasket.TotalPrice;
            buyer.Amount -= customerBasket.TotalPrice;

            Transaction transaction = new Transaction(
                customerBasket.Contents,
                DateTime.Now,
                buyer,
                Account
            );
            Transactions.Add(transaction);
        }
    }
}





