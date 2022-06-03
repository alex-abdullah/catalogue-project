using System;
namespace Project
{
    public class SelectionThree
    {
        public static void UserPrompts()
        {
            Console.WriteLine("Which catalogue do you want\nto delete a product from? \n");
            Console.WriteLine("1 - Hoodie catalogue");
            Console.WriteLine("2 - Jumprope catalogue \n");
        }

        public static void OptionOne(Catalogue<Hoodie> catalogue)
        {
            Catalogue<Hoodie>.DeleteFromCatalogue(catalogue);
            Catalogue<Hoodie>.SaveState(catalogue, "hoodie");
        }

        public static void OptionTwo(Catalogue<JumpRopes> catalogue)
        {
            Catalogue<JumpRopes>.DeleteFromCatalogue(catalogue);
            Catalogue<JumpRopes>.SaveState(catalogue, "jumprope");
        }
    }
}
