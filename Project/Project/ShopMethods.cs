using System;
namespace Project
{
    public class ShopMethods
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
            Console.WriteLine("1 - View existing catalogue");
            Console.WriteLine("2 - Add product to catalogue");
            Console.WriteLine("3 - Remove product from catalogue");
            Console.WriteLine("4 - Clear catalogue");
            Console.WriteLine("");
            Console.WriteLine("0 - Save & Exit");
            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}
