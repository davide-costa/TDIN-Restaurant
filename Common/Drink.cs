using System;

namespace Common
{
    [Serializable]
    public class Drink : Product
    {
        public Drink(string name, double price) : base(name, price) { }
    }
}
