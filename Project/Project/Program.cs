using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Project
{

    class Program
    {
    
        static void Main(string[] args)
        {           

            ShopMethods.InitialWelcome();
            bool programActive = true;

            Catalogue<Hoodie> catalogueHoodie = Hoodie.CatalogueGenerator();
            Catalogue<JumpRopes> catalogueJumpRope = JumpRopes.CatalogueGenerator();

            Menu.ShopMenu(programActive, catalogueHoodie, catalogueJumpRope);
            //while (programActive)
            //{               

            //    int input = ShopMethods.GettingUserInput();
                              
            //    if (input == 1)
            //        SelectionOne.DisplayCatalogues(catalogueHoodie, catalogueJumpRope);

            //    if (input == 2)
            //        SelectionTwo.UserSelectionTwo(catalogueHoodie, catalogueJumpRope);
             
            //    if (input == 3)
            //        SelectionThree.UserSelectionThree(catalogueHoodie, catalogueJumpRope);

            //    if(input == 4)
            //        SelectionFour.UserSelectionFour(catalogueHoodie, catalogueJumpRope);

            //    else if(input == 5)
            //    {
            //        programActive = false;
            //    }
            //}
        }
    }
}

