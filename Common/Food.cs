using System;

namespace Common
{
    [Serializable]
    public class Food : Product
    {
        public Food(string name, double price) : base(name, price) {}
    }
}
