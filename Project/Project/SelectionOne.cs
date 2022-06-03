using System;
namespace Project
{
    public class SelectionOne
    {
        public static void DisplayCatalogues(Catalogue<Hoodie> catalogueHoodie, Catalogue<JumpRopes> catalogueJumpRope)
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

        
    }
}
