using System;
namespace Project
{
    public class Hoodie : Product
    {
        private string _colour;
        private string _size;

        public string Colour { get => _colour; set => _colour = value; }
        public string Size { get => _size; set => _size = value; }


        public Hoodie(string itemName, double price, string colour, string size) : base(itemName, price)
        {
            _colour = colour;
            _size = size;
        }

        public Hoodie() : base()
        {

        }

        
    }
}
