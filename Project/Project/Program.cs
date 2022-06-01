using System;

namespace Project
{
    /* TODO
     * 
     * using PEN & PAPER => draw up program flow for each selection
     * consider how much refactoring you need to do once a -
     * - working version of the program is available
     * create a new file / class to store all shop static methods
     */

    class ShopMethods
    {
        public static void InitialWelcome()
        {
            Console.WriteLine("Welcome to Warehouse Simulator! {(^o^)}");
            Console.WriteLine("");            
        }

        public static void OpeningMessage()
        {
            Console.WriteLine("Enter a number to proceed:");
            Console.WriteLine("");
            ShowOptions();
        }

        public static void ShowOptions()
        {
            Console.WriteLine("1 - Create new catalogue");
            Console.WriteLine("2 - View existing catalogue");
            Console.WriteLine("3 - Add product to catalogue");
            Console.WriteLine("4 - Remove product from catalogue");
            Console.WriteLine("5 - Remove catalogue");
            Console.WriteLine("");            
            Console.WriteLine("0 - Save & Exit");
            Console.WriteLine("");
            Console.WriteLine("");

        }        
    }

    class Program
    {
        static void Main(string[] args)
        {

            ShopMethods.InitialWelcome();
            bool programActive = true;

            while (programActive)
            {
                ShopMethods.OpeningMessage();
                CatalogueList<Catalogue<Product>> jumpRopeCatalogueList = new CatalogueList<Catalogue<Product>>();
                CatalogueList<Catalogue<Product>> hoodieCatalogueList = new CatalogueList<Catalogue<Product>>();

                string userInput = Console.ReadLine();
                if(userInput == "1")
                {
                    Console.WriteLine("What item catalogue do you want to create?");
                    Console.WriteLine("");
                    Console.WriteLine("1 - New hoodie catalogue");
                    Console.WriteLine("2 - New jump rope catalogue");

                    string userSelection = Console.ReadLine();

                    if (userSelection == "1")
                    {
                        Console.WriteLine("Enter catalogue name:");
                        string catalogueName = Console.ReadLine();

                        Catalogue<Product> catalogueHoodie = new Catalogue<Product>();

                        Console.WriteLine("Enter hoodie NAME:");
                        string hoodieName = Console.ReadLine();

                        Console.WriteLine("Enter hoodie PRICE:");
                        string hoodiePrice = Console.ReadLine();
                        double.Parse(hoodiePrice);

                        Console.WriteLine("Enter hoodie COLOUR:");
                        string hoodieColour = Console.ReadLine();

                        Console.WriteLine("Enter hoodie SIZE");
                        string hoodieSize = Console.ReadLine();

                        Hoodie hoodieOne = new Hoodie(catalogueName, double.Parse(hoodiePrice), hoodieColour, hoodieSize);

                        catalogueHoodie.Add(hoodieOne);

                        hoodieCatalogueList.Add(catalogueHoodie);


                        Console.WriteLine($"{hoodieName} has been added to {catalogueName}");
                    }

                    if (userSelection == "2")
                    {
                        Console.WriteLine("Enter catalogue name:");
                        string catalogueName = Console.ReadLine();

                        Catalogue<Product> catalogueJumpRope = new Catalogue<Product>();

                        Console.WriteLine("Enter rope NAME:");
                        string ropeName = Console.ReadLine();

                        Console.WriteLine("Enter rope PRICE:");
                        string ropePrice = Console.ReadLine();
                        double.Parse(ropePrice);

                        Console.WriteLine("Enter rope LENGTH (feet/inches):");
                        string ropeLength = Console.ReadLine();
                        Int32.Parse(ropeLength);

                        Console.WriteLine("Enter rope COLOURWAY NAME");
                        string ropeColourway = Console.ReadLine();

                        JumpRopes ropeOne = new JumpRopes(ropeName, double.Parse(ropePrice), Int32.Parse(ropeLength), ropeColourway);

                        catalogueJumpRope.Add(ropeOne);
                        jumpRopeCatalogueList.Add(catalogueJumpRope);

                        Console.WriteLine($"{ropeName} has been added to {catalogueName}");

                    }

                } if(userInput == "2")
                {

                }
            }
            

        }
    }
}
