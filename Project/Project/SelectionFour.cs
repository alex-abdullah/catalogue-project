using System;
namespace Project
{
    public class SelectionFour
    {
        public static void UserPrompts()
        {
            Console.WriteLine("Which catalogue do you want to clear? \n");
            Console.WriteLine("1 - Hoodie catalogue");
            Console.WriteLine("2 - Jumprope catalogue \n");
        }

        public static void OptionOne(Catalogue<Hoodie> catalogue)
        {
            catalogue.Empty();
            Catalogue<Hoodie>.SaveState(catalogue, "hoodie");
            Console.WriteLine("Hoodie Catalogue is now empty\n");
        }

        public static void OptionTwo(Catalogue<JumpRopes> catalogue)
        {
            catalogue.Empty();
            Catalogue<JumpRopes>.SaveState(catalogue, "Jumprope");
            Console.WriteLine("Jumprope Catalogue is now empty\n");
        }
    }
}
