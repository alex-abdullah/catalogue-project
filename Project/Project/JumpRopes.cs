using System;
namespace Project
{
    public class JumpRopes : Product
    {
        private int _length;       
        public int Length { get => _length; set => _length = value; }
        

        public JumpRopes(string itemName, double price, int length) : base(itemName, price)
        {
            _length = length;
            
        }

        public JumpRopes() : base()
        {

        }
    }
}
