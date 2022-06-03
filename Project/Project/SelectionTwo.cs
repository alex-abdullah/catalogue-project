using System;
namespace Project
{
    public class SelectionTwo
    {
        public static void UserPrompts()
        {
            Console.WriteLine("What product do you want to create? \n");
            Console.WriteLine("1 - New hoodie");
            Console.WriteLine("2 - New jump rope \n");
        }

        public static void OptionOne(Catalogue<Hoodie> catalogue)
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

            catalogue.Add(hoodieOne);

            Console.WriteLine($"{hoodieName} has been added! \n");

            Catalogue<Hoodie>.SaveState(catalogue, "hoodie");
            Console.WriteLine("");
        }

        public static void OptionTwo(Catalogue<JumpRopes> catalogue)
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

            catalogue.Add(ropeOne);

            Console.WriteLine($"{ropeColourway} has been added! \n");

            Catalogue<JumpRopes>.SaveState(catalogue, "jumprope");

        }
    }
}
