using System;

namespace Common
{
    [Serializable]
    public class OrderReadyNotification
    {
        private static int CurrId = 1;
        public int Id;
        public ComplexOrder Order;

        public OrderReadyNotification(ComplexOrder order)
        {
            this.Id = CurrId;
            CurrId++;
            this.Order = order;
        }

        public OrderReadyNotification(int id, ComplexOrder order)
        {
            this.Id = id;
            this.Order = order;
        }
    }
}
