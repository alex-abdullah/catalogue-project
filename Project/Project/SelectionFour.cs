using System;
namespace Project
{
    public class SelectionFour
    {
        public static void UserSelectionFour(Catalogue<Hoodie> catalogue, Catalogue<JumpRopes> catalogue1)
        {
            UserPrompts();
            string userSelection = Console.ReadLine();

            if (userSelection == "1")
            {
                OptionOne(catalogue);

            }

            else if (userSelection == "2")
            {
                OptionTwo(catalogue1);
            }
            else
            {
                Console.WriteLine("Please enter 1 or 2...\n");
            }
        }

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
