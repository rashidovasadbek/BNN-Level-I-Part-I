using N32_T3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N32_T3.Service
{
    public class ProductService
    {
        private static ProductService _instance;

        public List<Product> _products = new();
        public static ProductService GetInstance()
        {
            if(_instance is null)
            {
                _instance = new ProductService();
            }
            return _instance;
        }

        public void Add(string name, string description)
        {
            _products.Add(new Product(name, description));
        }
        public void Clone(Guid id)
        {
            var product = _products.FirstOrDefault(a => a.Id == id);
            if(product != null)
            {
                var result = new Product(product);
                _products.Add(result);
            }

        }
        public void Display()
        {
            foreach (Product item in _products)
                Console.WriteLine( $"Id:{item.Id} Name:{item.Name} Description:{item.Description}");
        }
    }

}
