using System;

namespace Common
{
    [Serializable]
    public class BasicOrder : Order
    {
        public int ProductId { get; }

        public BasicOrder(int productId, double productPrice, int tableNumber, state state, int quantity, string description)
            : base(productPrice, tableNumber, state, quantity, description)
        {
            this.ProductId = productId;
        }

        public BasicOrder(int productId, double productPrice, int tableNumber, int quantity, string description)
            : this(productId, productPrice, tableNumber, state.NOT_PICKED, quantity, description) { }
    }
}
