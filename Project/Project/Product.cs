using System;
using System.Collections.Generic;
namespace Project
{
    public class Product
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

        public virtual double CalculateTax(double price, double tax)
        {
            if(price <= 0 || tax <= 0 || tax > price)
            {
                throw new Exception("Please ensure inputs are valid.");
            }

            double result = price * (1 + tax);
            return Math.Round(result, 2);
        }

        public override string ToString()
        {
            return _itemName;
        }
    }
}
