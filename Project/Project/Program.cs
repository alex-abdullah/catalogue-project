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
                

            while (programActive)
            {
                ShopMethods.OpeningMessage();

                string userInput = Console.ReadLine();

                if (userInput == "1")
                    SelectionOne.DisplayCatalogues(catalogueHoodie, catalogueJumpRope);


                if (userInput == "2")
                {
                    SelectionTwo.UserPrompts();
                    string userSelection = Console.ReadLine();

                    if (userSelection == "1")
                        SelectionTwo.OptionOne(catalogueHoodie);
                    SelectionTwo.OptionTwo(catalogueJumpRope);
                }

                if (userInput == "3")
                {
                    SelectionThree.UserPrompts();
                    string userSelection = Console.ReadLine();
                    

                    if (userSelection == "1")
                    {
                        SelectionThree.OptionOne(catalogueHoodie);
                    }
                    else if (userSelection == "2")
                    {
                        SelectionThree.OptionTwo(catalogueJumpRope);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 1 or 2...");
                    }
                }

                else if(userInput == "4")
                {
                    SelectionFour.UserPrompts();
                    string userSelection = Console.ReadLine();

                    if (userSelection == "1")
                    {
                        SelectionFour.OptionOne(catalogueHoodie);

                    }

                    else if (userSelection == "2")
                    {
                        SelectionFour.OptionTwo(catalogueJumpRope);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 1 or 2...\n");
                    }

                }
                else if(userInput == "0")
                {
                    programActive = false;
                }
            }
        }
    }
}

