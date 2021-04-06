using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryUnit7
{
    public class ProductRepository
    {
        private readonly Product[] Products = new[]
        {
            new Product (1, "товар 1", "нужен для чего-то такого"),
            new Product(2, "товар 2", "нужен для чего-то такого еще"),
            new Product(3, "товар 3", "нужен для чего-то такого"),
        };

        public Product[] GetAllByName(string Name)
        {
            return Products.Where(Product => Product.NameProd.Contains(Name)).ToArray();
        }
    }
}
