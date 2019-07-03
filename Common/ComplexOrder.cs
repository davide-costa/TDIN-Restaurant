using System;

namespace Common
{
    [Serializable]
    public class ComplexOrder : Order
    {
        public Product Product { get; }

        public ComplexOrder(Product product, int tableNumber, state state, int quantity, string description)
            : base(product.Price, tableNumber, state, quantity, description)
        {
            this.Product = product;
        }
    }
}
