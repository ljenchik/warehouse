namespace Warehouse
{
    public class CustomerBasket
    {
        public Dictionary<Item, int> contents { get; set;} = new Dictionary<Item, int>();
        public void AddItemInBasket(Item item, int amount)
        {
            this.contents.Add(item, amount);
        }

        public void RemoveItemFromBasket(Item item)
        {
            int amount = contents[item];
            if (amount > 0)
            {
                contents[item] = amount - 1;
            }
        }
        public decimal CalculateTotalPrice()
        {
            decimal totalSum = 0;
            foreach (var element in contents)
            {
                totalSum += element.Key.itemPrice * element.Value;
            }
            return totalSum;
        }
    }

}