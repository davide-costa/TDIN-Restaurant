using System;

namespace Common
{
    [Serializable]
    public class Order
    {
        public enum state { NOT_PICKED, IN_PREPARATION, READY };
        private static int CurrId = 1;
        public int Id { get; }
        public int TableNumber { get; }
        public state State { get; set; }
        public double Price { get; }
        public int Quantity { get; }
        public string Description { get; }

        public Order(double productPrice, int tableNumber, state state, int quantity, string description)
        {
            this.Id = CurrId;
            CurrId++;
            this.TableNumber = tableNumber;
            this.State = state;
            this.Price = productPrice * quantity;
            this.Quantity = quantity;
            this.Description = description;
        }
    }
}
