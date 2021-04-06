using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryUnit7
{
    public class Product
    {
        public int IdProd { get; }
        public string NameProd { get; }
        public string Description { get; }

        public Product(int id, string nameProd, string description)
        {
            IdProd = id;
            NameProd = nameProd;
            Description = description;
        }


    }
}
