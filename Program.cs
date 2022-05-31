using System;

namespace Warehouse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Item item = new Item();
            item.itemName = "apple";
            item.itemPrice = 1.45m;
            Console.WriteLine(item.itemPrice);
            Console.WriteLine(item.itemName);
            CustomerBasket myBasket = new CustomerBasket();
            myBasket.AddItemInBasket(item, 5);
            Console.WriteLine(myBasket.contents);
            Console.WriteLine(myBasket.CalculateTotalPrice());
            myBasket.RemoveItemFromBasket(item);
            Console.WriteLine(myBasket.CalculateTotalPrice());
        }
    }
}