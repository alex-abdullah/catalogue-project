using System;
namespace Project
{
    public class CatalogueList<T> where T : Catalogue<Product>
    {
        private CatalogueList<T> _listOfCatalogues;
        public CatalogueList<T> ListOfCatalogues => _listOfCatalogues;
              
        public CatalogueList()
        {            
            _listOfCatalogues = new CatalogueList<T>();
        }

        public void Add(Catalogue<Product> Catalogue) 
        {
            _listOfCatalogues.Add(Catalogue);
        }
    }
}
