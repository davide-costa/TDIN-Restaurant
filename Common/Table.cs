using System.Collections.Generic;

namespace Common
{
    public class Table
    {
        public enum state { OPEN, CLOSED };
        private static int CurrNumber = 1;
        public int Number { get; }
        public List<ComplexOrder> Orders { get; }
        public state State { get; set; }


        protected Table(state state)
        {
            this.Number = CurrNumber;
            CurrNumber++;
            this.State = state;
            Orders = new List<ComplexOrder>();
        }

        /**
         * Creates and initializes a table with state CLOSED
         */
        public Table() : this(state.CLOSED) { }

        public void AddOrders(List<ComplexOrder> orders)
        {
            Orders.AddRange(orders);
            SetAsOpen();
        }

        public void SetAsOpen()
        {
            State = state.OPEN;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Table objAsPart = obj as Table;
            if (objAsPart == null)
                return false;

            return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return Number;
        }
        public bool Equals(Table other)
        {
            if (other == null)
                return false;

            return (this.Number.Equals(other.Number));
        }

        public List<ComplexOrder> Close()
        {
            State = state.CLOSED;
            List<ComplexOrder> tableOrders = new List<ComplexOrder>(Orders);
            Orders.Clear();

            return tableOrders;
        }
    }
}
