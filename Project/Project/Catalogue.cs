using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace Project
{
    public class Catalogue<T> where T : Product
    {
        private string _catName;
        public string CatName { get => _catName; set => _catName = value; }

        private List<T> _productCatalogue;
        public List<T> ProductCatalogue { get => _productCatalogue; set => _productCatalogue = value; }

        public Catalogue()
        {
            _productCatalogue = new List<T>();
            _catName = CatName;
        }

        public void Add(T product)
        {
            if (product == null)
                throw new NullReferenceException("Please enter valid input");
            _productCatalogue.Add(product);
        }

        public void Remove(T product)
        {
            if (product == null)
                throw new NullReferenceException("Please enter valid input");
            _productCatalogue.Remove(product);
        }

        public void RemoveAtIndex(int i)
        {
            if (i < 0 || i >= _productCatalogue.Count)
            {
                throw new Exception($"Index {i} is out of bounds - please select an item between 0 and {_productCatalogue.Count}");
                
            }
            _productCatalogue.RemoveAt(i);
        }

        static public void DeleteFromCatalogue(Catalogue<T> catalogue)
        {

            int size = catalogue.CountItems();

            if (size == 0)
            {
                Console.WriteLine("This catalogue is empty so you cannot delete an item");
                return;
            }

            Console.WriteLine($"There are {size} item(s) in this catalogue. Which one would you like to remove?");
            for (int i = 0; i < size; i++)
            {
                //TODO add a ToString virtual method for the product
                Console.WriteLine($"\n{i} - item {i}\n");
            };

            string userSelection = Console.ReadLine();
            //TODO ensure try-catch
            int result = Int32.Parse(userSelection);

            catalogue.RemoveAtIndex(result);

            Console.WriteLine("You successfully removed an item");

        }

        public void Empty()
        {
            _productCatalogue.Clear();
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (T x in _productCatalogue) 
            {
                total += (x.Price * (1 + x.Tax));
            }

            return total;
        }

        public int CountItems()
        {
            int count = 0;
            foreach(var item in _productCatalogue)
            {
                count += 1;
            }
            return count;
        }

        public static void SaveState(Catalogue<T> catalogue, string path)
        {
            string jsonObject = JsonSerializer.Serialize(catalogue);
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), path + ".json");
            File.WriteAllText(filePath, jsonObject);

        }

        public static Catalogue<T> LoadState(string path)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), path + ".json");
            string jsonObject = File.ReadAllText(filePath);

            //Console.WriteLine(jsonObject);

            return JsonSerializer.Deserialize<Catalogue<T>>(jsonObject);

            // to deserialise successfully, you require a default constructor
            // for ALL classes, parents and children as well as getters and setters for each field

            // technically you can deserialise without setters, BUT shit is gonna
            // go super weird. So use setters

            // 1st error => no setters on catalogues list member variables
            // 2nd error => after we added setters, hoodie/jumprope was unable
            // to be created due to no default constructor
            
        }

        public override string ToString()
        {
            return "Item";
        }

    }
}
