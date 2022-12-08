using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Observer
{
    enum Category
    {
        A, B, C, D
    }

    interface IObservable<T>
    {
        void Subscribe(params T[] observer);
        void Unsubscribe(params T[] observer);
        void Notify();
    }

    interface IObserver<T>
    {
        void Update(T product);
    }

    class Product : IObservable<Customer>
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }

        private decimal discount;
        public decimal Discount
        {
            get { return discount; }
            set
            {
                if (value > discount)
                {
                    Notify();
                }
                discount = value;
            }
        }

       
        private readonly List<Customer> observers = new List<Customer>();

        public void Notify()
        {
            observers.ForEach(observer => observer.Update(this));
        }

        public void Subscribe(params Customer[] newObservers)
        {
            observers.AddRange(newObservers);
        }

        public void Unsubscribe(params Customer[] observersToRemove)
        {
            
            observers.RemoveAll(observersToRemove.Contains);
        }
    }

    class Customer : IObserver<Product>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Category> FavouriteCategories { get; set; }

        public void Update(Product product)
        {
            if (FavouriteCategories.Contains(product.Category))
            {
                Console.WriteLine($"{product.Name} cena: {product.Price * (1 - product.Discount)} wysłano: {Email}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>()
            {
                new Customer()
                {
                    Name = "Piotr",
                    Email = "piotr@gmail.com",
                    FavouriteCategories = new List<Category> {Category.A, Category.C}
                },
                new Customer()
                {
                    Name = "Pawel",
                    Email = "pawel@gmail.com",
                    FavouriteCategories = new List<Category> {Category.B, Category.D}
                }
            };

            var products = new List<Product>()
            {
                new Product()
                {
                    Name = "przedmiot 1",
                    Category = Category.A,
                    Price = 15.2m,
                    Discount = 0.1m
                },
                new Product()
                {
                    Name = "przedmiot 2",
                    Category = Category.B,
                    Price = 15.2m,
                    Discount = 0.11m
                },
                new Product()
                {
                    Name = "przedmiot 3",
                    Category = Category.C,
                    Price = 16.2m,
                    Discount = 0.15m
                },
                new Product()
                {
                    Name = "przedmiot 4",
                    Category = Category.D,
                    Price = 12.6m,
                    Discount = 0.14m
                }
            };

            
            products.ForEach(product => product.Subscribe(customers.ToArray()));

            Console.WriteLine("\nPoczątkowa cena");
            products.ForEach(product => product.Discount += 0.4m);

            Console.WriteLine("\nPierwsza zmiana");
            products.ForEach(product => product.Discount -= 0.1m);

            Console.WriteLine("\nDruga zmiana");
            products
                .Where(product => product.Category == Category.A)
                .ToList()
                .ForEach(product => product.Discount += 0.2m);
        }
    }
}