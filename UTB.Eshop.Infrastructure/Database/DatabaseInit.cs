using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.Eshop.Domain.Entities;

namespace UTB.Eshop.Infrastructure.Database
{
    internal class DatabaseInit
    {
        public List<Product> ProductInit()
        {
            List<Product> products = new List<Product>();

            products.Add(
                new Product()
                {
                    Id = 1,
                    Name = "Chleba",
                    Description = "",
                    Price = 20,
                    ImageSource = "/img/produkty-02.jpg"
                });


            products.Add(
                new Product()
                {
                    Id = 2,
                    Name = "Rohlík",
                    Description = "",
                    Price = 5,
                    ImageSource = "/img/produkty-01.jpg"
                });


            products.Add(
                new Product()
                {
                    Id = 3,
                    Name = "Věneček",
                    Description = "",
                    Price = 40,
                    ImageSource = "/img/produkty-08.jpg"
                });

            return products;
        }
    }
}
