using System;
namespace Project
{
    public abstract class Product
    {
        private double _price;
        private double _tax = 0.1;
        private string _itemName;
        
        public double Price => _price;
        public double Tax => _tax;
        public string ItemName => _itemName;
        
        public Product(string itemName, double price)
        {
            _itemName = itemName;
            _price = price;           
        }

        public virtual double CalculateTax()
        {
            return _price * (1 + _tax);
        }

        public override string ToString()
        {
            return _itemName;
        }
    }
}
