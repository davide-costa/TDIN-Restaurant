using System;

namespace Common
{
    [Serializable]
    public abstract class Product
    {
        private static int CurrId = 1;
        public int Id { get; }
        public string Name { get; }
        public double Price { get; }

        protected Product(string name, double price)
        {
            this.Id = CurrId;
            CurrId++;
            this.Name = name;
            this.Price = price;
        }
    }
}
