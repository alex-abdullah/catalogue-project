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
            
        }
    }
}

