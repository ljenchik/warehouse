namespace Warehouse
{
    public class CustomerBasket
    {
        public Dictionary<Item, int> Contents { get; set; } = new Dictionary<Item, int>();

        public CustomerBasket (Dictionary<Item, int> contents)
        {
            Contents = contents;
        }


        public decimal TotalPrice
        {
            get
            {
                decimal totalSum = 0;
                foreach (var element in Contents)
                {
                    totalSum += element.Key.itemPrice * element.Value;
                }
                return totalSum;
            }
        }

        public void AddItemInBasket(Item item, int amount)
        {
            Contents.Add(item, amount);
        }

        public void RemoveItemFromBasket(Item item)
        {
            int amount = Contents[item];
            if (amount > 0)
            {
                Contents[item] = amount - 1;
            }
        }
    }

}