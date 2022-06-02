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
            Product product = new Product();

            ShopMethods.InitialWelcome();
            bool programActive = true;

            Catalogue<Hoodie> catalogueHoodie;
            Catalogue<JumpRopes> catalogueJumpRope;          

            try
            {                
                catalogueHoodie = Catalogue<Hoodie>.LoadState("hoodie");
                Console.WriteLine("Hoodie catalogue successfully loaded.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No save file found.\n");                
                catalogueHoodie = new Catalogue<Hoodie>();
                
            }

            try
            {
                catalogueJumpRope = Catalogue<JumpRopes>.LoadState("jumprope");
                Console.WriteLine("Jump rope catalogue successfully loaded.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No save file found.\n");
                catalogueJumpRope = new Catalogue<JumpRopes>();
            }


            while (programActive)
            {
                ShopMethods.OpeningMessage();

                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    if (catalogueHoodie.CountItems() <= 0)
                    {
                        Console.WriteLine("HOODIE CATALOGUE");
                        Console.WriteLine("Hoodie catalogue is empty\n");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("HOODIE CATALOGUE");
                        Console.WriteLine($"{catalogueHoodie.CatName} \n");
                        catalogueHoodie.ProductCatalogue.ForEach(Console.WriteLine);
                        Console.WriteLine("");
                    }


                    if (catalogueJumpRope.CountItems() <= 0)
                    {
                        Console.WriteLine("JUMP ROPE CATALOGUE");
                        Console.WriteLine("Jump rope catalogue is empty\n");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("JUMP ROPE CATALOGUE");
                        Console.WriteLine($"{catalogueJumpRope.CatName} \n");
                        catalogueJumpRope.ProductCatalogue.ForEach(Console.WriteLine);
                        Console.WriteLine("");
                    }

                }

                else if (userInput == "2")
                {
                    Console.WriteLine("What product do you want to create? \n");
                    Console.WriteLine("1 - New hoodie");
                    Console.WriteLine("2 - New jump rope \n");
                    string userSelection = Console.ReadLine();

                    if (userSelection == "1")
                    {
                        Console.WriteLine("Enter hoodie NAME:");
                        string hoodieName = Console.ReadLine();

                        Console.WriteLine("Enter hoodie PRICE:");
                        string hoodiePrice = Console.ReadLine();
                        double.Parse(hoodiePrice);

                        Console.WriteLine("Enter hoodie COLOUR:");
                        string hoodieColour = Console.ReadLine();

                        Console.WriteLine("Enter hoodie SIZE");
                        string hoodieSize = Console.ReadLine();


                        Hoodie hoodieOne = new Hoodie(hoodieName, double.Parse(hoodiePrice), hoodieColour, hoodieSize);

                        catalogueHoodie.Add(hoodieOne);

                        Console.WriteLine($"{hoodieName} has been added! \n");

                        Catalogue<Hoodie>.SaveState(catalogueHoodie, "hoodie");
                        Console.WriteLine("");

                    }

                    else if (userSelection == "2")
                    {
                        Console.WriteLine("Enter rope COLOURWAY NAME:");
                        string ropeColourway = Console.ReadLine();

                        Console.WriteLine("Enter rope PRICE:");
                        string ropePrice = Console.ReadLine();
                        double.Parse(ropePrice);

                        Console.WriteLine("Enter rope LENGTH (feet/inches):");
                        string ropeLength = Console.ReadLine();
                        Int32.Parse(ropeLength);

                        JumpRopes ropeOne = new JumpRopes(ropeColourway, double.Parse(ropePrice), Int32.Parse(ropeLength));

                        catalogueJumpRope.Add(ropeOne);

                        Console.WriteLine($"{ropeColourway} has been added! \n");

                        Catalogue<JumpRopes>.SaveState(catalogueJumpRope, "jumprope");
                    }

                }
                else if(userInput == "3")
                {
                    Console.WriteLine("Which catalogue do you want\nto delete a product from? \n");
                    Console.WriteLine("1 - Hoodie catalogue");
                    Console.WriteLine("2 - Jumprope catalogue \n");
                    string userSelection = Console.ReadLine();
                    int result = Int32.Parse(userSelection);

                    if (userSelection == "1")
                    {
                        Catalogue<Hoodie>.DeleteFromCatalogue(catalogueHoodie);
                        Catalogue<Hoodie>.SaveState(catalogueHoodie, "hoodie");

                    }
                    else if (userSelection == "2")
                    {
                        Catalogue<JumpRopes>.DeleteFromCatalogue(catalogueJumpRope);
                        Catalogue<JumpRopes>.SaveState(catalogueJumpRope, "jumprope");
                    }
                    else
                    {
                        Console.WriteLine("Please enter 1 or 2...");
                    }
                }

                else if(userInput == "4")
                {
                    Console.WriteLine("Which catalogue do you want to clear? \n");
                    Console.WriteLine("1 - Hoodie catalogue");
                    Console.WriteLine("2 - Jumprope catalogue \n");
                    string userSelection = Console.ReadLine();

                    if (userSelection == "1")
                    {
                        catalogueHoodie.Empty();
                        Catalogue<Hoodie>.SaveState(catalogueHoodie, "hoodie");
                        Console.WriteLine("Hoodie Catalogue is now empty\n");

                    }
                    else if (userSelection == "2")
                    {
                        catalogueJumpRope.Empty();
                        Catalogue<JumpRopes>.SaveState(catalogueJumpRope, "jumprope");
                        Console.WriteLine("Jumprope Catalogue is now empty\n");
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

