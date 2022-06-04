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
            Console.WriteLine("5 - Save & Exit");
            Console.WriteLine("");
            Console.WriteLine("");

        }

        public static int GettingUserInput()
        {
            OpeningMessage();

            int Selection = -1;

            while (Selection == -1)
            {
                Console.WriteLine("Enter a number to proceed:");
                string UserSelection = Console.ReadLine();
                Console.WriteLine("");
                int result = TryParseIndex(UserSelection, 5);
                if (result != -1)
                    Selection = result;
            }

            return Selection;
        }


        public static int TryParseIndex(string strIndex, int lastOptionNumber)
        {
            try
            {                
                int index = Int32.Parse(strIndex);

                if (index > 0 && index < lastOptionNumber)
                {
                    return index;
                }
                else
                {
                    Console.WriteLine("Valid number was not entered");
                    return -1;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Valid number was not entered");
                return -1;
            }
        }
    }
}
