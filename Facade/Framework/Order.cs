namespace Facade.Framework
{
    /// <summary>
    /// Class named Order that will represent the order coming from the User.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Name of dish.
        /// </summary>
        public string DishName { get; set; }

        /// <summary>
        /// Dish price.
        /// </summary>
        public double DishPrice { get; set; }

        /// <summary>
        /// User name.
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Shipping address.
        /// </summary>
        public string ShippingAddress { get; set; }

        /// <summary>
        /// Shipping price.
        /// </summary>
        public double ShippingPrice { get; set; }

        public Order(string dishName, double dishPrice, string user, string shippingAddress)
        {
            DishName = dishName;
            DishPrice = dishPrice;
            User = user;
            ShippingAddress = shippingAddress;
        }

        public override string ToString()
        {
            return $"{User} ordered {DishName}. The full price is {DishPrice + ShippingPrice} dollars.";
        }
    }
}