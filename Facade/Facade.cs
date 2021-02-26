using Facade.Framework;

using System.Collections.Generic;

namespace Facade
{
    /// <summary>
    /// The Facade class will act as a "middleware" between the User and the complexity of the system without changing the business logic.
    /// </summary>
    public class Facade
    {
        /// <summary>
        /// Component OnlineOrder.
        /// </summary>
        private readonly OnlineOrder _onlineOrder;

        /// <summary>
        /// Component Shipping.
        /// </summary>
        private readonly Shipping _shipping;

        /// <summary>
        /// Initialization of system objects.
        /// </summary>
        /// <param name="onlineOrder"> Order. </param>
        /// <param name="shipping"> Shipping. </param>
        public Facade(OnlineOrder onlineOrder, Shipping shipping)
        {
            _onlineOrder = onlineOrder;
            _shipping = shipping;
        }

        /// <summary>
        /// The Facade methods are convenient shortcuts to the sophisticated functionality of the subsystems.
        /// However, clients get only to a fraction of a subsystems capabilities.
        /// </summary>
        /// <param name="orders"> Collection of orders. </param>
        public void OrderFood(List<Order> orders)
        {
            // Add order to cart.
            foreach (Order order in orders)
            {
                _onlineOrder.AddOrderToCart(order);
            }

            // Message that order is successfully complete.
            _onlineOrder.CompleteOrders();

            // Manipulation of shipping. 
            foreach (Order order in orders)
            {
                _shipping.AcceptOrder(order);
                _shipping.CalculateShippingExpenses();
                _shipping.ShipOrder();
            }
        }
    }
}