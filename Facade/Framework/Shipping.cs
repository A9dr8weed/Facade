using System;

namespace Facade.Framework
{
    /// <summary>
    /// The Shipping class accepts the order and ships them to the address.
    /// </summary>
    public class Shipping
    {
        /// <summary>
        /// Reference to Order.
        /// Object to know shipping address.
        /// </summary>
        private Order _order;

        public void AcceptOrder(Order order)
        {
            _order = order;
        }

        /// <summary>
        /// Shipping costs.
        /// </summary>
        public void CalculateShippingExpenses()
        {
            _order.ShippingPrice = 15.5;
        }

        /// <summary>
        /// Displays to the user.
        /// </summary>
        public void ShipOrder()
        {
            Console.WriteLine(_order.ToString());
            Console.WriteLine($"Order is being shipped to {_order.ShippingAddress}...\n");
        }
    }
}