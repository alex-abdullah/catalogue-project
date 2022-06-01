using System;
namespace Project
{
    public class JumpRopes : Product
    {
        private int _length;
        private string _style;

        public int Length => _length;
        public string Style => _style;

        public JumpRopes(string itemName, double price, int length, string style) : base(itemName, price)
        {
            _length = length;
            _style = style;
        }
    }
}
