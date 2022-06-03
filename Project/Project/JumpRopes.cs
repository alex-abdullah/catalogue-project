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

        public static Catalogue<JumpRopes> CatalogueGenerator()
        {
            Catalogue<JumpRopes> catalogue;

            try
            {
                catalogue = Catalogue<JumpRopes>.LoadState("jumprope");
                Console.WriteLine("Jump rope successfully loaded.\n");
                return catalogue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("No save file found.\n");
                catalogue = new Catalogue<JumpRopes>();
                return catalogue;

            }

        }
    }
}
