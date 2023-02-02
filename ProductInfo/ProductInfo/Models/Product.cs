using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductInfo.Models
{
    public class Product
    {
        private string id;
        private string name;
        private double price;
        
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price 
        {
            get { return price; }
            set { price = value; }
        }
        public Product(string id, string name, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
    }
}