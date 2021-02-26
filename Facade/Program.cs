using Facade.Framework;

using System.Collections.Generic;

namespace Facade
{
    public static class Program
    {
        private static void Main()
        {
            OnlineOrder onlineOrder = new OnlineOrder();
            Shipping shipping = new Shipping();

            Facade facade = new Facade(onlineOrder, shipping);

            Order chickenOrder = new Order("Chicken with rice", 20.0, "User1", "Random street 123");
            Order sushiOrder = new Order("Sushi", 52.0, "User2", "More random street 321");

            facade.OrderFood(new List<Order>() { chickenOrder, sushiOrder });
        }
    }
}