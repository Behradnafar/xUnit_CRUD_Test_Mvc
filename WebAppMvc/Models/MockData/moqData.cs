using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvc.Models.Entites;

namespace WebAppMvc.Models.MockData
{
    public class moqData
    {

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>()
            {
                 new Product { Id = 1 , Description ="x" , Name="iphone x" , Price = 15000},
                 new Product { Id = 2 , Description ="x2" , Name="iphone xx" , Price = 1000},
            };
            return products;
        }
    }
}
