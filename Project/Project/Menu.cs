using System;
namespace Project
{
    public class Menu
    {
        public static void ShopMenu(bool programStatus, Catalogue<Hoodie> catalogue, Catalogue<JumpRopes> catalogue1)
        {
            programStatus = true;

            while (programStatus == true)
            {

                int input = ShopMethods.GettingUserInput();

                if (input == 1)
                    SelectionOne.DisplayCatalogues(catalogue, catalogue1);

                if (input == 2)
                    SelectionTwo.UserSelectionTwo(catalogue, catalogue1);

                if (input == 3)
                    SelectionThree.UserSelectionThree(catalogue, catalogue1);

                if (input == 4)
                    SelectionFour.UserSelectionFour(catalogue, catalogue1);

                else if (input == 5)
                {
                    programStatus = false;
                }
            }
        }
    }
}
