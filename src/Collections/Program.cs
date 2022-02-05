using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collections
{
    public class Program
    {
        public class Products
        {
            public string Name { get; set; }
        }
        public static void Main(string[] args)
        {
            var states = new Dictionary<string, string>();
            states.Add("ca", "California");
            states.Add("ga", "Georgia");
            states.Add("tx", "Texas");

            Console.WriteLine(states["ca"]);
            Console.ReadLine();

            //var products = new List<Products>();
            //products.Add(new Products { Name = "Phone" });
            //products.Add(new Products { Name = "Laptop" });

            //var products = new List<Products>();
            //products.Add(new Products { Name = "Phone" });
            //products.Add(new Products { Name = "Laptop" });
            //products.Add(new Products { Name = "TV" });
            //products.Add(new Products { Name = "CPU" });

            //var Product1 = products[1];
            //Console.WriteLine(Product1.Name);
            //Console.ReadLine();


            //var movies = new string[3];

            //movies[0] = "Star Wars";
            //movies[1] = "King Kong";
            //movies[2] = "Memento";
            //movies[3] = "300";

            //var movies = new List();
            //movies.Add("Star Wars");
            //movies.Add("King Kong");
            //movies.Add("Memento");

        }
    }
}
