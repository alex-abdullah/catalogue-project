using System;
using System.Collections.Generic;
namespace Project
{
    public class CatalogueList<T> where T : Catalogue<Product>
    {
        private List<T> _listOfCatalogues;
        public List<T> ListOfCatalogues => _listOfCatalogues;
              
        public CatalogueList()
        {            
            _listOfCatalogues = new List<T>();
        }

        public void Add(T Catalogue) 
        {
            _listOfCatalogues.Add(Catalogue);
        }

        
    }
}
