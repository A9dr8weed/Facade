using System;
using System.Collections.Generic;

namespace Facade.Framework
{
    /// <summary>
    /// The OnlineRestaurant class provides methods for adding orders to the cart.
    /// </summary>
    public class OnlineOrder
    {
        /// <summary>
        /// Collection of orders.
        /// Cart.
        /// </summary>
        private readonly List<Order> _cart;

        public OnlineOrder()
        {
            _cart = new List<Order>();
        }

        /// <summary>
        /// Add order to cart.
        /// </summary>
        /// <param name="order"> Added product. </param>
        public void AddOrderToCart(Order order)
        {
            Console.WriteLine($"{order.DishName} add to cart.");

            _cart.Add(order);
        }

        /// <summary>
        /// Message, that order is successfully complete.
        /// </summary>
        public void CompleteOrders()
        {
            Console.WriteLine("Orders completed. Dispatch in progress...\n");
        }
    }
}