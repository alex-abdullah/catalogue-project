using System;
namespace Project
{
    public class Hoodie : Product
    {
        private string _colour;
        private string _size;

        public string Colour => _colour;
        public string Size => _size;


        public Hoodie(string itemName, double price, string colour, string size) : base(itemName, price)
        {
            _colour = colour;
            _size = size;
        }


        
    }
}
