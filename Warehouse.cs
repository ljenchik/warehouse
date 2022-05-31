namespace Warehouse
{
    public class Warehouse
    {
        public Dictionary<Item, int> stock { get; } = new Dictionary<Item, int>();
        public Account account { get; set; }
        public Transaction transaction { get; set; }


        public void SellItem(Item item, int amount, Account seller)
        {
            int stockAmount = stock[item];
            if (stockAmount >= amount)
            {
                stock[item] = stockAmount - amount;
                seller.accountNumber += item.itemPrice * amount;
            }
        }
        public void AddItem(Item item, int amount, Account seller)
        {
            stock[item] += amount;
            if (item.itemPrice * amount <= seller.accountNumber)
            {
                seller.accountNumber -= item.itemPrice * amount;
            }
        }

        public bool IsInStock(Item item)
        {
            return stock[item] > 0;
        }

    }

}