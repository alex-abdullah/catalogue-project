using System;
using System.Collections.Generic;
namespace Project
{
    public abstract class Product
    {
        private double _price;
        private double _tax;
        private string _itemName;
        
        public double Price { get => _price; set => _price = value; }
        public double Tax { get => _tax; set => _tax = 0.1; }
        public string ItemName { get => _itemName; set => _itemName = value; }
        
        public Product(string itemName, double price)
        {
            _itemName = itemName;
            _price = price;           
        }

        public Product()
        {

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
