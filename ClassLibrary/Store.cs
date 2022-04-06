using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Store
    {
        Product[] _products = new Product[0];

        public Product[] Products { get; set; }
        public void AddProduct(Product product)
        {
            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
        }
        public void RemoveProductByNo(int no)
        {
            int count = 0;
            foreach (var pr in _products)
            {
                if (pr.No==no)
                {
                    foreach (var item in _products)
                    {
                        item.No = item.No + 1;
                    }
                    count++;
                    break;
                }
            }
            if (count==0)
            {
                Console.WriteLine("bu no deyerinde product tapilmadi!");
            }
            else
            {
                Console.WriteLine("product ugurla silindi.");
                foreach (var item in _products)
                {
                    Console.WriteLine(item);
                }
            }

        }

        public Product[] FilterProductsByType(ProductType type)
        {
            Product[] products = new Product[0];
            foreach (var pr in _products)
            {
                if (pr.Type == type)
                {
                    Array.Resize(ref products, products.Length + 1);
                    products[products.Length - 1] = pr;
                }
            }
            return products;
        }

        public void FilterProductByName(string name)
        {
            foreach (var item in _products)
            {
                if (item.Name==name)
                    Console.WriteLine(item);
            }
        }
    }
}
