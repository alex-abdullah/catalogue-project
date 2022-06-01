using System;
using System.Collections.Generic;
namespace Project
{
    public class Catalogue<T> where T : Product
    {
        private List<T> _productCatalogue;
        public List<T> _ProductCatalogue => _productCatalogue;

        public Catalogue()
        {
            _productCatalogue = new List<T>();
        }

        public void Add(T product)
        {
            _productCatalogue.Add(product);
        }

        public void Remove(T product)
        {
            _productCatalogue.Remove(product);
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (T x in _productCatalogue)
            {
                total += x.CalculateTax();
            }

            return total;
        }

        
    }
}
