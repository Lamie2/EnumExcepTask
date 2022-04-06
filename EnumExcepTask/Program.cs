using System;
using ClassLibrary;
namespace EnumExcepTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Product product1 = new Product();
            product1.Name = "corek";
            product1.No = 1;
            product1.Price = 60;
            product1.Type = ProductType.Baker;


            Product product2 = new Product();
            product2.Name = "coca cola";
            product2.No = 2;
            product2.Price = 1.5;
            product2.Type = ProductType.Drink;

            Product product3 = new Product();
            product3.Name = "kolbasa";
            product3.No = 3;
            product3.Price = 4;
            product3.Type = ProductType.Meat;

            Product product4 = new Product();
            product4.Name = "pendir";
            product4.No = 4;
            product4.Price = 4;
            product4.Type = ProductType.Diary;



            Console.WriteLine("==================MENU==================");
            Console.WriteLine($"Zehmet olmasa seciminizi edin: \n 1.Product elave etmek  " +
                $"\n 2.Type-a gore filterlemek ");

            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    store.AddProduct(product1);
                    Console.WriteLine(product1.Name+ " " + product1.Price + " " + product1.Type);

                    break;

                case "2":
                    
                    foreach (var item in store.FilterProductsByType(ProductType.Baker))
                    {
                        Console.WriteLine(item.Name + " " + item.Price);
                    }
                    
                    break;

                default:
                    Console.WriteLine("duzgun secim edin!");
                    break;
            }

        }
    }
}
