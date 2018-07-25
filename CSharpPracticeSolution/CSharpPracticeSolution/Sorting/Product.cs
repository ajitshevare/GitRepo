using System.Collections.Generic;

namespace CSharpPracticeSolution.Sorting
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
                
        public List<Product> GetProducts()
        {
            return new List<Product>{
            new Product{
                Id = 4,
                Name = "Cement"
            },
            new Product
            {
                Id = 5,
                Name = "Coffee"
            },
             new Product{
                Id = 1,
                Name = "Rum"
            },
            new Product
            {
                Id = 2,
                Name = "Tea"
            },
            new Product
            {
                Id = 3,
                Name = "Oil"
            }
           };
        }
    }
}
        
