using System;

namespace Warehouse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Item apple = new Item("apple", 0.75m);
            Item strawberry = new Item("strawberry", 3);
            Item bread = new Item("bread", 2);
            Item yogurt = new Item("yogurt", 2);
            Item icecream = new Item("icecream", 4);

            Warehouse warehouse = new Warehouse(
               new Dictionary<Item, int>
               {
                    { apple, 50 },
                    { strawberry, 25 },
                    {bread, 100 },
                    { yogurt, 70 },
                    { icecream, 40 },
               }
           );
            Console.WriteLine($"Stock in warehouse:");
            foreach (Item item in warehouse.Stock.Keys)
            {
                Console.WriteLine($"{item.itemName}, {item.itemPrice}, {warehouse.Stock[item]}");
            }

            Account p1 = new Account(100);
            Account p2 = new Account(50);

            CustomerBasket p1Basket = new CustomerBasket(
                new Dictionary<Item, int>
                {
                    { strawberry, 2},
                    { apple, 5}
                }
            );

            CustomerBasket p2Basket = new CustomerBasket(
                new Dictionary<Item, int>
                {
                    { bread, 1},
                    { icecream, 4},
                    {yogurt, 3}
                }
            );

            warehouse.SellItem(p1Basket, p1);
            warehouse.SellItem(p2Basket, p2);

            Console.WriteLine($"Stock in warehouse after purchase:");
            foreach (Item item in warehouse.Stock.Keys)
            {
                Console.WriteLine($"{item.itemName}, {item.itemPrice}, {warehouse.Stock[item]}");
            }

            Console.WriteLine($"p1 now has £{p1.Amount}");
            Console.WriteLine($"p2 now has £{p2.Amount}");

            Console.WriteLine("Warehouse transactions list:");
            foreach (Transaction transaction in warehouse.Transactions)
            {
                Console.WriteLine($"\tTransaction made at {transaction.DateTime}");
            }

        }
    }
}
